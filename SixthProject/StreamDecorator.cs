using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SixthProject
{
    abstract class StreamDecorator: Stream
    {
        protected FileStream  fileStream;

        public StreamDecorator(FileStream fileStream) :base()
        {
            this.fileStream = fileStream;
        }

        abstract protected bool IsRightPassword(string password);
    }
}
