﻿namespace Kalix.ApiCrypto.EC
{
    public class ECCertificateBuilderOptions
    {
        /// <summary>
        /// Full distinguished name that will be used in the certificate
        /// ie. CN=Subject
        /// </summary>
        public string FullSubjectName { get; set; }

        /// <summary>
        /// Name of the internal EC keypair that is created
        /// </summary>
        public string ECDSAKeyName { get; set; }

        /// <summary>
        /// Select from the supported curves, higher key length is more secure
        /// </summary>
        public ECNamedCurves? ECCurve { get; set; }

        /// <summary>
        /// Select from the supported hashing methods, higher key length is more secure
        /// </summary>
        public HashingMethods? HashingMethod { get; set; }
    }
}
