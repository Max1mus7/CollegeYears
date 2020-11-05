using System;
using System.Net;

namespace TryCatchFinallyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = null;
            var resultData = "";
            try
            {
                wc = new WebClient();
                resultData = wc.DownloadString("http://google2.com");

            }
            catch(WebException ex)
            {
                Console.WriteLine("This is the web exception: " + ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("This is the catch for the ArgumentNullException: " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This is the catch all exception: " + ex);
            }
            
            finally
            {
                Console.WriteLine(resultData);
                Console.ReadKey();
                wc?.Dispose();
            }
        }
    }
}
