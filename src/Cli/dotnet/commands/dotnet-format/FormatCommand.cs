﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.CommandLine.Parsing;
using System.Linq;
using Microsoft.DotNet.Cli;
using Microsoft.DotNet.Cli.Utils;

namespace Microsoft.DotNet.Tools.Format
{
    public class FormatCommand : DotnetFormatForwardingApp
    {
        public FormatCommand(IEnumerable<string> argsToForward) : base(argsToForward)
        {
        }

        public static FormatCommand FromArgs(string[] args)
        {
            var parser = Cli.Parser.Instance;
            var result = parser.ParseFrom("dotnet format", args);
            return FromParseResult(result);
        }

        public static FormatCommand FromParseResult(ParseResult result)
        {
            return new FormatCommand(result.GetValueForArgument(FormatCommandParser.Arguments));
        }

        public static int Run(ParseResult parseResult)
        {
            parseResult.HandleDebugSwitch();

            return FromParseResult(parseResult).Execute();
        }

        public static int Run(string[] args)
        {
            DebugHelper.HandleDebugSwitch(ref args);
            return new DotnetFormatForwardingApp(args).Execute();
        }
    }
}
