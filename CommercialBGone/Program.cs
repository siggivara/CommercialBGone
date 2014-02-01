namespace CommercialBGone
{
    class Program
    {
        static void Main(string[] args)
        {
            const string templatePath = @"C:\source\images\tv2_2_transparent.png";
            const string sourceImagePath = @"C:\source\images\tv2_2_transparent.png";

            var match = TemplateMatching.TemplateMatching.TemplateIsInImage(templatePath, sourceImagePath);
        }
    }
}
