// Guids.cs
// MUST match guids.h
using System;

namespace Company.NotesApp
{
    static class GuidList
    {
        public const string guidNotesAppPkgString = "64b14516-6519-450f-ab9a-6afcb8ee0340";
        public const string guidNotesAppCmdSetString = "199be00d-d478-44e3-ab33-c14e556db00d";
        public const string guidToolWindowPersistanceString = "0989f71f-9cb2-42a5-bdae-a58e84a6c520";

        public static readonly Guid guidNotesAppCmdSet = new Guid(guidNotesAppCmdSetString);
    };
}