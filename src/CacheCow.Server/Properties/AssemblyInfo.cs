﻿using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("CacheCow.Server")]
[assembly: AssemblyDescription("Server library for CacheCow project")]

#if BUILDTESTS
[assembly: InternalsVisibleTo("CacheCow.Tests")]
#endif