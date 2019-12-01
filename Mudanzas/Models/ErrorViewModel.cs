using System;

namespace Mudanzas.Models
{
    public class ErrorViewModel
    {
        private string RequestId { get; set; }

        private bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
