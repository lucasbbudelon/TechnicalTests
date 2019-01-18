using System;
using System.Runtime.Serialization;

namespace MultipleExceptions
{
    class Program
    {
        public Logger Logger { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void CacheDataToFile()
        {
            MyDataReader reader = GetDataReader();

            try
            {
                SaveToFile(reader, "SomeFileName.dat");
                Logger.Write("File saved successfully");
            }
            catch (UserFriendlyException userFriendlyException)
            {
                throw userFriendlyException;
            }
            catch (FileAlreadyExistsException fileAlreadyExistsException)
            {
                this.Logger.Write(fileAlreadyExistsException.InnerException.Message);
            }
            catch (Exception genericException)
            {
                throw new UserFriendlyException("Unable to save data to cache", genericException);
            }
            finally
            {
                reader.Close();
            }
        }

        private void SaveToFile(MyDataReader reader, string v)
        {
            throw new NotImplementedException();
        }

        private MyDataReader GetDataReader()
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class FileAlreadyExistsException : Exception
    {
        public FileAlreadyExistsException()
        {
        }

        public FileAlreadyExistsException(string message) : base(message)
        {
        }

        public FileAlreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileAlreadyExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class UserFriendlyException : Exception
    {
        public UserFriendlyException()
        {
        }

        public UserFriendlyException(string message) : base(message)
        {
        }

        public UserFriendlyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserFriendlyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    internal class MyDataReader
    {
        internal void Close()
        {
            throw new NotImplementedException();
        }
    }

    internal class Logger
    {
        internal void Write(string v)
        {
            throw new NotImplementedException();
        }
    }
}
