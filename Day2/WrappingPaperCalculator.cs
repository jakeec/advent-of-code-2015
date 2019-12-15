using System;
using System.Collections.Generic;

namespace Day2
{
    public class Present
    {
        public int l { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class WrappingPaperCalculator
    {
        public WrappingPaperCalculator()
        {

        }

        private List<Present> ConvertStringToPresents(string presents)
        {
            var pres = presents.Split('\n');
            var presents2 = new List<Present>();
            foreach (var present in pres)
            {
                var dimensions = present.Split("x");
                presents2.Add(new Present
                {
                    l = int.Parse(dimensions[0]),
                    w = int.Parse(dimensions[1]),
                    h = int.Parse(dimensions[2])
                });
            }
            return presents2;
        }

        public int CalculateWrappingPaperRequired(string presentsString)
        {
            var presents = ConvertStringToPresents(presentsString);

            var totalWrappingPaper = 0;
            foreach (var present in presents)
            {
                totalWrappingPaper += FindRequiredWrappingPaper(present);
            }

            return totalWrappingPaper;
        }

        public int CalculateRibbonRequired(string presentsString)
        {
            var presents = ConvertStringToPresents(presentsString);

            var totalRibbon = 0;
            foreach (var present in presents)
            {
                totalRibbon += FindRequiredRibbon(present);
            }

            return totalRibbon;
        }

        private int FindRequiredRibbon(Present present)
        {
            return FindSmallestPerimeter(present) + FindVolume(present);
        }

        private int FindSmallestPerimeter(Present present)
        {
            int l = present.l, w = present.w, h = present.h;
            List<int> faces = new List<int>();
            faces.Add(2 * l + 2 * w);
            faces.Add(2 * w + 2 * h);
            faces.Add(2 * h + 2 * l);
            faces.Sort();
            return faces[0];
        }

        private int FindVolume(Present present)
        {
            return present.l * present.w * present.h;
        }

        private int FindRequiredWrappingPaper(Present present)
        {
            return FindSurfaceArea(present) + FindSlack(present);
        }

        private int FindSlack(Present present)
        {
            int l = present.l, w = present.w, h = present.h;
            List<int> dimensions = new List<int>();
            dimensions.Add(l * w);
            dimensions.Add(w * h);
            dimensions.Add(h * l);
            dimensions.Sort();
            return dimensions[0];
        }

        private int FindSurfaceArea(Present present)
        {
            int l = present.l, w = present.w, h = present.h;
            return 2 * l * w + 2 * w * h + 2 * h * l;
        }
    }
}