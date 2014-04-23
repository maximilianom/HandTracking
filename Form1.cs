using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace HandTrack {
  public partial class Form1 : Form {
    //Ycc yccMin = new Ycc(0, 131, 80);
    //Ycc yccMax = new Ycc(255, 185, 135);

    bool ycc = true;
    bool bgr = false;
    bool hsv = false;

    Capture capture = null;
    bool binCapturingInProcess = false;

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      try {
        capture = new Capture();
      } catch (Exception exception) {
        txtXYRadius.Text = exception.Message;
        return;
      }

      checkGaussian.Checked = true;
      checkErosion.Checked = true;
      checkDilation.Checked = true;
      checkCamera.Checked = true;

      Application.Idle += processFrameAndUpdateGUI;
      binCapturingInProcess = true;
    }

    private void Form1_formClosed(object sender, FormClosedEventArgs args) {
      if (capture != null) {
        capture.Dispose();
      }
    }

    private void btmPauseOrResume_Click(object sender, EventArgs e) {
      if (binCapturingInProcess == true) {
        Application.Idle -= processFrameAndUpdateGUI;
        binCapturingInProcess = false;

        btmPauseOrResume.Text = "resume";
      } else {
        Application.Idle += processFrameAndUpdateGUI;
        binCapturingInProcess = true;
        btmPauseOrResume.Text = "pause";
      }
    }

    void processFrameAndUpdateGUI(object sender, EventArgs e) {
      Image<Bgr, Byte> originalImg = capture.QueryFrame();

      if (originalImg == null) return;

      using (MemStorage storage = new MemStorage()) {
        Image<Gray, Byte> processedImg = filterImage(originalImg);
        Contour<Point> contours = processedImg.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);

        Contour<Point> biggest = contours;
        while (contours != null) {
          if (contours.Area > biggest.Area) {
              biggest = contours;
          }
          contours = contours.HNext;
        }

        if (biggest != null) {
          biggest = biggest.ApproxPoly(biggest.Perimeter * 0.0001 * ((int)numPerimeterApprox.Value), storage);
          Seq<MCvConvexityDefect> defects = biggest.GetConvexityDefacts(storage, ORIENTATION.CV_CLOCKWISE);

          int defectCount = Enumerable.Count(defects);
          bool isHand = defectCount >= 4 && defectCount <= 9; // check this

          if (!isHand) {
            originalImg.Draw(biggest, new Bgr(Color.Red), 2);
          } else {
            Seq<Point> hull = biggest.GetConvexHull(ORIENTATION.CV_CLOCKWISE);
            originalImg.Draw(biggest, new Bgr(Color.LimeGreen), 2);

            originalImg.DrawPolyline(hull.ToArray(), true, new Bgr(Color.Yellow), 2);

            List<PointF> points = new List<PointF>();
            foreach (MCvConvexityDefect defect in defects) {
              points.Add(defect.DepthPoint);
              CircleF circle = new CircleF(defect.DepthPoint, 4);
              originalImg.Draw(circle, new Bgr(Color.Blue), 2);

              //CircleF start = new CircleF(defect.StartPoint, 4);
              //originalImg.Draw(start, new Bgr(Color.Red), 2);

              CircleF end = new CircleF(defect.EndPoint, 4);
              originalImg.Draw(end, new Bgr(Color.DarkRed), 2);
            }

            if (points.Count != 0) {
              CircleF palm = PointCollection.MinEnclosingCircle(points.ToArray());
              originalImg.Draw(palm, new Bgr(Color.Red), 2);
            }
          }
          ////////////////////////////////////////////////////////////
          // end auxiliar lines
        }

        ibOriginal.Image = originalImg;
        ibProcessed.Image = processedImg;
      }
    }

    private Image<Gray, Byte> filterImage(Image<Bgr, Byte> originalImg) {
      Image<Gray, Byte> processedImg = null;
      if (ycc) {
        processedImg = originalImg.Convert<Ycc, Byte>().InRange(
          new Ycc((double)Ymin.Value, (double)CrMin.Value, (double)CbMin.Value),
          new Ycc((double)Ymax.Value, (double)CrMax.Value, (double)CbMax.Value));
      } else if (bgr) {
        processedImg = originalImg.InRange(
          new Bgr((double)BMin.Value, (double)GMin.Value, (double)RMin.Value),
          new Bgr((double)BMax.Value, (double)GMax.Value, (double)RMax.Value));
      } else if (hsv) {
        processedImg = originalImg.Convert<Hsv, Byte>().InRange(
          new Hsv((double)HMin.Value, (double)SMin.Value, (double)VMin.Value),
          new Hsv((double)HMax.Value, (double)SMax.Value, (double)VMax.Value));
      }

      if (checkGaussian.Checked) {
        processedImg = processedImg.PyrUp().PyrDown().SmoothGaussian(9);
      }

      if (checkErosion.Checked) {
        StructuringElementEx rect_12 = new StructuringElementEx(12, 12, 6, 6, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
        CvInvoke.cvErode(processedImg, processedImg, rect_12, 1);
      }

      if (checkDilation.Checked) {
        StructuringElementEx rect_6 = new StructuringElementEx(6, 6, 3, 3, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
        CvInvoke.cvDilate(processedImg, processedImg, rect_6, 2);
      }
      return processedImg;
    }

    private void tabColorTolerance_SelectedIndexChanged(object sender, EventArgs e) {
      if (txtXYRadius.Text != "") {
        txtXYRadius.AppendText(Environment.NewLine);
      }
      txtXYRadius.AppendText("Tab changed. Index: " + tabColorTolerance.SelectedTab.ToString());

      // This should be a FACTORY and a STRATEGY pattern
      if (tabColorTolerance.SelectedIndex == 0) {
        hsv = false;
        bgr = false;
        ycc = true;
      } else if (tabColorTolerance.SelectedIndex == 1) {
        hsv = false;
        ycc = false;
        bgr = true;
      } else if (tabColorTolerance.SelectedIndex == 2) {
        hsv = true;
        ycc = false;
        bgr = true;
      }
    }

    private void checkCamera_CheckedChanged(object sender, EventArgs e) {
      //if (checkCamera.Checked) {
      //  if (capture != null) {
      //    capture.Dispose();
      //  }
      //  capture = new Capture();
      //} else {
      //  if (capture != null) {
      //    capture.Dispose();
      //  }
      //  capture = new Capture("C:\\Users\\Maxi\\Desktop\\Videos\\video.mp4");
      //}
    }
  }
}
