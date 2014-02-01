using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace TemplateMatching
{
    public class TemplateMatching
    {
        public static bool TemplateIsInImage(string templateImagePath, string sourceImagePath)
        {
            var templateImage = new Image<Bgr, Byte>(templateImagePath);
            var sourceImage = new Image<Bgr, Byte>(sourceImagePath);

            Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage,
                Emgu.CV.CvEnum.TM_TYPE.CV_TM_CCOEFF_NORMED);

            float[, ,] matches = resultImage.Data;
            for (int x = 0; x < matches.GetLength(1); x++)
            {
                for (int y = 0; y < matches.GetLength(0); y++)
                {
                    double matchScore = matches[y, x, 0];
                    if (matchScore > 0.75)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
