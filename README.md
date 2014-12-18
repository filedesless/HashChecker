HashChecker
===========
HashChecker is a C# .Net software with the purpose of computing checksums for messages or files in the intent of verifying their integrity.

>File was downloaded without errors
>File is what the uploader has signed
>Does not give more trust to the said file, just help ensure it is the same

Originally developed for:
https://hightechlowlife.eu


             ,ggg,        gg  ,ggggggggggggggg       ,gggg,         ,gggg,        
            dP""Y8b       88 dP""""""88"""""""      d8" "8I        d8" "8I        
            Yb, `88       88 Yb,_    88             88  ,dP        88  ,dP        
             `"  88       88  `""    88          8888888P"      8888888P"         
                 88aaaaaaa88         88             88             88             
                 88"""""""88         88             88             88             
                 88       88         88        ,aa,_88        ,aa,_88             
                 88       88   gg,   88       dP" "88P       dP" "88P             
                 88       Y8,   "Yb,,8P       Yb,_,d88b,,_   Yb,_,d88b,,_         
                 88       `Y8     "Y8P'        "Y8P"  "Y88888 "Y8P"  "Y88888       



Project licensied under MIT License, see ./LICENSE.md for more informations


UTILITY
=======
Allows you to calculate and verify checksums. For example, if you download a file for wich the publisher has set a MD5 hash, you can make sure that the file you downloaded is exactly the file the publisher has uploaded by comparing his MD5 hash with the one calculated by this software.

This software can compute the MD5, SHA1, SHA256 or SHA512 checksum of a file, and allows you to compare it with the publisher's similar checksum. Make sure to compute the hash using the good algorithm. If the two checksums (the publisher's one and your calculated one) are the same, it is safe to assume the file hasn't been tampered since upload.

IT DOES NOT IN ANY WAY MEAN THAT THE FILE IS NOT DANGEROUS/INFECTED.

HOW TO INSTALL
==============
Standalone executable.
Just grab HashChecker.exe

As a .Net program, it currently only supports Windows Operating system.

CHANGELOG
=========
>2014-12-17:
* Release V1.0 is out

LICENSE
=======
The MIT License (MIT)

Copyright (c) 2014 aigleleu

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

 
