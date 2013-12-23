﻿namespace Kalix.ApiCrypto.RSA
{
    public class RSACertificateBuilderOptions
    {
        /// <summary>
        /// Full distinguished name that will be used in the certificate
        /// ie. CN=Subject
        /// </summary>
        public string FullSubjectName { get; set; }

        /// <summary>
        /// Name of the internal RSA keypair that is created
        /// </summary>
        public string RSAKeyName { get; set; }

        /// <summary>
        /// Select your RSA key size - Uses Cng which supports 512 to 16384 in 64-bit increments
        /// </summary>
        public int? KeySize { get; set; }

        /// <summary>
        /// Select from the supported hashing methods, higher key length is more secure
        /// </summary>
        public HashingMethods? HashingMethod { get; set; }
    }
}
