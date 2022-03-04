// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Underscores allowed in event names.")]

[assembly: SuppressMessage("Security", "CA2361:Ensure auto-generated class containing DataSet.ReadXml() is not used with untrusted data", Justification = "Security is out of scope of project")]
[assembly: SuppressMessage("Security", "CA2362:Unsafe DataSet or DataTable in auto-generated serializable type can be vulnerable to remote code execution attacks", Justification = "Out of project scope")]
[assembly: SuppressMessage("Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Security is out of scope of project")]

[assembly: SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Globalization not needed in this project")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "Globalization not needed in this project")]
[assembly: SuppressMessage("Globalization", "CA1307:Specify StringComparison for clarity", Justification = "Globalization not needed in this project")]

[assembly: SuppressMessage("Design", "CA1014:Mark assemblies with CLSCompliant", Justification = "Assembly compliance not required in project")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "All exceptions handeled same way")]