using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mora.Common.Vault
{
    public class Result
    {
        public const string RESULT_SUCCEEDED_CODE = "0";
        public const string RESULT_SUCCEEDED_DESCRIPTION = "succeeded";

        public const string RESULT_FAILED_CODE = "-1";
        public const string RESULT_FAILED_DESCRIPTION = "failed";

        public const string RESULT_GENERAL_TECH_ERROR_CODE = "-2";
        public const string RESULT_GENERAL_TECH_ERROR_DESCRIPTION = "general technical error";

        public const string RESULT_GENERAL_BUSINESS_ERROR_CODE = "-3";
        public const string RESULT_GENERAL_BUSINESS_ERROR_DESCRIPTION = "general business error";

        public const string RESULT_SKIPPED_CODE = "-4";
        public const string RESULT_SKIPPED_DESCRIPTION = "skipped";
    }
}
