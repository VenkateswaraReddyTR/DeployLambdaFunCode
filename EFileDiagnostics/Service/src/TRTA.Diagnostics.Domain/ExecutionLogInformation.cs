using System;
using System.Collections.Generic;
using System.Text;

namespace TRTA.Diagnostics.Domain
{
    public class DiagnosticsInfo
    {
        public string RuleId { get; set; }
        public string RuleNumber { get; set; }
        public string Reason { get; set; }
        public List<dynamic> Categories { get; set; }
        public List<Log> Log { get; set; }
        public List<FormattedRuleText> FormattedTexts { get; set; }
        public int NumberOfDiagnostics { get; set; }
        public int NumberOfNoDiagnostics { get; set; }
        public string GoTo { get; set; }
    }

    public class Log
    {
        public int evaluationId { get; set; }
        public string methodName { get; set; }
        public string finalResult { get; set; }
        public List<LogEntry> logEntries { get; set; }
    }

    public class FormattedRuleText
    {
        public string formattedRuleText;
        public int evaluationId;
    }

    public class LogEntry
    {
        public LogEntry()
        {
        }

        public string description;
        public string value;
        public string fieldKey;
        public string fieldName;
    }
}
