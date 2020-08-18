using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishy_Model.Request
{
    [Serializable]
    public class Response
    {
        public ResponseState State { get; set; }
        private object body;
        public object Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
                State = ResponseState.NotNull;
            }
        }

        public Response()
        {
            this.State = ResponseState.IsNull;
        }

        public Response(ResponseState type, object body)
        {
            this.State = type;
            this.Body = body;
        }
        public enum ResponseState
        {
            IsNull,
            NotNull,
            Error
        }
    }
}
