// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Security.Cryptography.X509Certificates;

namespace System.Net.Security
{
    public partial class SslStreamCertificateContext
    {
        internal static SslStreamCertificateContext Create(X509Certificate2 target)
        {
            // On OSX we do not need to build chain unless we are asked for it.
            return new SslStreamCertificateContext(target, Array.Empty<X509Certificate2>());
        }
    }
}
