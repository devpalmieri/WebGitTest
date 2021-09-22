using System;

namespace WebGitTest.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }//modifica

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
