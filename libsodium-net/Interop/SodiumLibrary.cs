using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable MemberCanBePrivate.Global

namespace Sodium.Interop
{
  internal static class SodiumLibrary
  {
    public const string Name = SodiumRuntimeConfig.LibraryName;

    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void sodium_init();

    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void randombytes_buf(byte[] buffer, int size);

    //randombytes_uniform
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int randombytes_uniform(int upperBound);

    //sodium_increment
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void sodium_increment(byte[] buffer, long length);

    //sodium_compare
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int sodium_compare(byte[] a, byte[] b, long length);

    //sodium_version_string
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr sodium_version_string();

    //crypto_hash
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_hash(byte[] buffer, byte[] message, long length);

    //crypto_hash_sha512
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_hash_sha512(byte[] buffer, byte[] message, long length);

    //crypto_hash_sha256
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_hash_sha256(byte[] buffer, byte[] message, long length);

    //crypto_generichash
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_generichash(byte[] buffer, int bufferLength, byte[] message, long messageLength, byte[] key, int keyLength);

    //crypto_generichash_blake2b_salt_personal
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_generichash_blake2b_salt_personal(byte[] buffer, int bufferLength, byte[] message, long messageLength, byte[] key, int keyLength, byte[] salt, byte[] personal);

    //crypto_onetimeauth
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_onetimeauth(byte[] buffer, byte[] message, long messageLength, byte[] key);

    //crypto_onetimeauth_verify
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_onetimeauth_verify(byte[] signature, byte[] message, long messageLength, byte[] key);

    //crypto_pwhash_str
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_pwhash_str(byte[] buffer, byte[] password, long passwordLen, long opsLimit, int memLimit);

    //crypto_pwhash_str_verify
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_pwhash_str_verify(byte[] buffer, byte[] password, long passLength);

    //crypto_pwhash
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_pwhash(byte[] buffer, long bufferLen, byte[] password, long passwordLen, byte[] salt, long opsLimit, int memLimit, int alg);

    //crypto_pwhash_scryptsalsa208sha256_str
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_pwhash_scryptsalsa208sha256_str(byte[] buffer, byte[] password, long passwordLen, long opsLimit, int memLimit);

    //crypto_pwhash_scryptsalsa208sha256
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_pwhash_scryptsalsa208sha256(byte[] buffer, long bufferLen, byte[] password, long passwordLen, byte[] salt, long opsLimit, int memLimit);

    //crypto_pwhash_scryptsalsa208sha256_str_verify
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_pwhash_scryptsalsa208sha256_str_verify(byte[] buffer, byte[] password, long passLength);

    //crypto_sign_keypair
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_keypair(byte[] publicKey, byte[] secretKey);

    //crypto_sign_seed_keypair
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_seed_keypair(byte[] publicKey, byte[] secretKey, byte[] seed);

    //crypto_sign
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign(byte[] buffer, ref long bufferLength, byte[] message, long messageLength, byte[] key);

    //crypto_sign_open
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_open(byte[] buffer, ref long bufferLength, byte[] signedMessage, long signedMessageLength, byte[] key);

    //crypto_sign_detached
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_detached(byte[] signature, ref long signatureLength, byte[] message, long messageLength, byte[] key);

    //crypto_sign_verify_detached
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_verify_detached(byte[] signature, byte[] message, long messageLength, byte[] key);

    //crypto_sign_ed25519_sk_to_seed
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_ed25519_sk_to_seed(byte[] seed, byte[] secretKey);

    //crypto_sign_ed25519_sk_to_pk
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_ed25519_sk_to_pk(byte[] publicKey, byte[] secretKey);

    //crypto_sign_ed25519_pk_to_curve25519
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_ed25519_pk_to_curve25519(byte[] curve25519Pk, byte[] ed25519Pk);

    //crypto_sign_ed25519_sk_to_curve25519
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_sign_ed25519_sk_to_curve25519(byte[] curve25519Sk, byte[] ed25519Sk);

    //crypto_box_keypair
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_keypair(byte[] publicKey, byte[] secretKey);

    //crypto_box_easy
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_easy(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] publicKey, byte[] secretKey);

    //crypto_box_open_easy
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_open_easy(byte[] buffer, byte[] cipherText, long cipherTextLength, byte[] nonce, byte[] publicKey, byte[] secretKey);

    //crypto_box_detached
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_detached(byte[] cipher, byte[] mac, byte[] message, long messageLength, byte[] nonce, byte[] pk, byte[] sk);

    //crypto_box_open_detached
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_open_detached(byte[] buffer, byte[] cipherText, byte[] mac, long cipherTextLength, byte[] nonce, byte[] pk, byte[] sk);

    //crypto_scalarmult_bytes
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_scalarmult_bytes();

    //crypto_scalarmult_scalarbytes
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_scalarmult_scalarbytes();

    //crypto_scalarmult_primitive
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern byte crypto_scalarmult_primitive();

    //crypto_scalarmult_base
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_scalarmult_base(byte[] q, byte[] n);

    //crypto_scalarmult
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_scalarmult(byte[] q, byte[] n, byte[] p);

    //crypto_box_seal
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_seal(byte[] buffer, byte[] message, long messageLength, byte[] pk);

    //crypto_box_seal_open
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_box_seal_open(byte[] buffer, byte[] cipherText, long cipherTextLength, byte[] pk, byte[] sk);

    //crypto_secretbox_easy
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_secretbox_easy(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] key);

    //crypto_secretbox_open_easy
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_secretbox_open_easy(byte[] buffer, byte[] cipherText, long cipherTextLength, byte[] nonce, byte[] key);

    //crypto_secretbox_detached
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_secretbox_detached(byte[] cipher, byte[] mac, byte[] message, long messageLength, byte[] nonce, byte[] key);

    //crypto_secretbox_open_detached
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_secretbox_open_detached(byte[] buffer, byte[] cipherText, byte[] mac, long cipherTextLength, byte[] nonce, byte[] key);

    //crypto_auth
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_auth(byte[] buffer, byte[] message, long messageLength, byte[] key);

    //crypto_auth_verify
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_auth_verify(byte[] signature, byte[] message, long messageLength, byte[] key);

    //crypto_auth_hmacsha256
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_auth_hmacsha256(byte[] buffer, byte[] message, long messageLength, byte[] key);

    //crypto_auth_hmacsha256_verify
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_auth_hmacsha256_verify(byte[] signature, byte[] message, long messageLength, byte[] key);

    //crypto_auth_hmacsha512
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_auth_hmacsha512(byte[] signature, byte[] message, long messageLength, byte[] key);

    //crypto_auth_hmacsha512_verify
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_auth_hmacsha512_verify(byte[] signature, byte[] message, long messageLength, byte[] key);

    //crypto_shorthash
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_shorthash(byte[] buffer, byte[] message, long messageLength, byte[] key);

    //crypto_stream_xor
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_stream_xor(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] key);

    //crypto_stream_chacha20_xor
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_stream_chacha20_xor(byte[] buffer, byte[] message, long messageLength, byte[] nonce, byte[] key);

    //sodium_bin2hex
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr sodium_bin2hex(byte[] hex, int hexMaxlen, byte[] bin, int binLen);

    //sodium_hex2bin
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int sodium_hex2bin(IntPtr bin, int binMaxlen, string hex, int hexLen, string ignore, out int binLen, string hexEnd);

    //crypto_aead_chacha20poly1305_encrypt
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_aead_chacha20poly1305_encrypt(
      IntPtr cipher, out long cipherLength, byte[] message, long messageLength, byte[] additionalData,
      long additionalDataLength, byte[] nsec, byte[] nonce, byte[] key);

    //crypto_aead_chacha20poly1305_decrypt
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_aead_chacha20poly1305_decrypt(
      IntPtr message, out long messageLength, byte[] nsec, byte[] cipher, long cipherLength, byte[] additionalData,
      long additionalDataLength, byte[] nonce, byte[] key);

    //crypto_aead_aes256gcm_is_available
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_aead_aes256gcm_is_available();

    //crypto_aead_aes256gcm_encrypt
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_aead_aes256gcm_encrypt(
      IntPtr cipher, out long cipherLength, byte[] message, long messageLength, byte[] additionalData,
      long additionalDataLength, byte[] nsec, byte[] nonce, byte[] key);

    //crypto_aead_aes256gcm_decrypt
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_aead_aes256gcm_decrypt(
      IntPtr message, out long messageLength, byte[] nsec, byte[] cipher, long cipherLength, byte[] additionalData,
      long additionalDataLength, byte[] nonce, byte[] key);

    //crypto_generichash_state
    [StructLayout(LayoutKind.Sequential, Size = 384)]
    [SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Global")]
    internal struct _HashState
    {
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public ulong[] h;

      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public ulong[] t;

      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public ulong[] f;

      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public byte[] buf;

      public uint buflen;

      public byte last_node;
    }

    //crypto_generichash_init
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_generichash_init(IntPtr state, byte[] key, int keySize, int hashSize);

    //crypto_generichash_update
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_generichash_update(IntPtr state, byte[] message, long messageLength);

    //crypto_generichash_final
    [DllImport(Name, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int crypto_generichash_final(IntPtr state, byte[] buffer, int bufferLength);
  }
}
