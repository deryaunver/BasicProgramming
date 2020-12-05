using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
           // TryCatch();
            HandleException(() => { Find(); });

            Console.ReadKey();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
              
            }
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>
            {
                "ali", "veli", "ayşe", "fatma"
            };
            if (!students.Contains("ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[4]
                {
                    "derya", "emrah", "duygu", "evren"
                };
                students[4] = "DENİZ";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
