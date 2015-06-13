// Guids.cs
// MUST match guids.h
using System;

namespace GerardWalace.BlameVSPackage
{
    static class GuidList
    {
        public const string guidBlameVSPackagePkgString = "479bb051-92f3-49d3-9e85-040c928d6b80";
        public const string guidBlameVSPackageCmdSetString = "17f0af00-f6aa-49dc-aa07-c1a30adf66dd";
        public const string guidBlameVSPackageEditorFactoryString = "01bb0228-1e41-4a4e-b185-e02a74682d13";

        public static readonly Guid guidBlameVSPackageCmdSet = new Guid(guidBlameVSPackageCmdSetString);
        public static readonly Guid guidBlameVSPackageEditorFactory = new Guid(guidBlameVSPackageEditorFactoryString);
    };
}