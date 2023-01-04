using System.Diagnostics;

namespace GIFConverter
{
    public class Converter
    {
        private readonly string ffmpegExecutable = "ffmpeg";

        private const string ARGUMENTS_TEMPLATE = "-i {0} -pix_fmt yuv420p {1}";

        public Converter(string ffmpegExecutable)
        {
            this.ffmpegExecutable = ffmpegExecutable;
        }

        public bool Convert(string source, string output)
        {
            var arguments = string.Format(ARGUMENTS_TEMPLATE, source, output);
            try
            {
                var proc = Process.Start(ffmpegExecutable, arguments);
                proc.WaitForExit();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
    }
}