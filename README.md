encr
====

encr is a simple RNG-One-Time-Pad cryptosystem for binary data. It is currently implented in VB.NET and can be compiled in VS2012 for .NET4.5.
The system creates a unique series of key bytes for each passphrase. Effectively, this creates 2^[length of hash]^[length of hash] possiblities for random byte keystreams.

====

How The Cryptosystem Works
----
Inputs:

- Bytes from any file

- Passphrase with any UTF-8 character

1.
A Hash for the passphrase is generated. Currently MD5, RIPEMD160, SHA1, SHA256, SHA384 and SHA 512 are possible because they are a part of the System.Security.Cryptography namespace, but others might be added.

2.
A Seed is generated. It it is created from the bytes of the UTF-8-encoded passphrase.

3.
The Bytearray is split into chunks of 1 hash length.
3.1
With each step, a byte from the hash is added to the seed
3.2
The seed is hashed. This should create enough enthropy to make sure no chunk is transformed using the same key.
3.3
The key and the chunk are added bit by bit without carryover (XOR).
3.4
The result chunk is appended to the output bytes

4.
The output bytes can be stored/transmitted.

Licensing
----

THE DWYLPL

This license allows you to do literally ANYTHING with this code, except reselling or saying "I made this.". This software might be considered illegal in certain countries that don't like cryptography. If any harm is done involving this software, it is explicitly NOT the authors fault. The software comes with no warranty.
