using System.Collections.Generic;
using DiffPatch.Core;
using DiffPatch.Data;

namespace DiffPatch
{
    public static class DiffParserHelper
    {
        public static IEnumerable<FileDiff> Parse(string input, string lineEnding = "\n")
            => new DiffParser().Run(StringHelper.SplitLines(input, lineEnding));
    }
}
