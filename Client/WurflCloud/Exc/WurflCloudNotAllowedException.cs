/**
 * Copyright (c) 2015 ScientiaMobile Inc.
 *
 * The WURFL Cloud Client is intended to be used in both open-source and
 * commercial environments. To allow its use in as many situations as possible,
 * the WURFL Cloud Client is dual-licensed. You may choose to use the WURFL
 * Cloud Client under either the GNU GENERAL PUBLIC LICENSE, Version 2.0, or
 * the MIT License.
 *
 * Refer to the COPYING.txt file distributed with this package.
 */

using System;

namespace ScientiaMobile.WurflCloud.Exc
{
    public class WurflCloudNotAllowedException : Exception
    {
        public override String Message
        {
            get
            {
                return "The operation is not allowed in the current version of the library.";
            }
        }
    }
}