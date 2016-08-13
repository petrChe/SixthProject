using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthProject
{
    class StreamWithPassword : StreamDecorator
    {
        private const string PASSWORD = "A1";
        public string UserPassword { get; private set; }

        public StreamWithPassword(FileStream fileStream, string pass) : base(fileStream)
        {
            this.UserPassword = pass;
        }

        public override bool CanRead
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool CanSeek
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool CanWrite
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override long Length
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override long Position
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                if (IsRightPassword(this.UserPassword))
                {
                    var result = this.fileStream.Read(buffer, offset, count);
                    return result;
                }
                else
                {
                    throw new PasswordExeption("Your password is incorrect!");
                }
            }
            catch(PasswordExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        protected override bool IsRightPassword(string password)
        {
            if (password.Equals(PASSWORD))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
