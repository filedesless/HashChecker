HashChecker
===========
HashChecker is a C# .Net software with the purpose of computing checksums for messages or files in the intent of verifying their integrity.

* Make sure file was downloaded without errors
* Help proving file wasn't tampered
* Does not prove the file's security, neither publisher's authenticity, just that the file hasn't been changed

Official GitHub webpage at:
http://aiglebleu.github.io/HashChecker

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

>Example 1:
- Let's say an evil publisher upload an infected file and its computed MD5 checksum
- You download the file, compute the MD5 hash on your side, and verify that the MD5 hashes correspond
- Everything looks fine BUT YOU STILL GOT INFECTED!!!
- Always download from trusted sources, and protect yourself with Anti-virus & Anti-malware. There's sadly nothing this software can do for you.

>Example 2:
- Now let's say a trusted publisher upload a legit file and its computed SHA256 checksum
- You download the file, compute the SHA256 hash on your side, and verify that the SHA256 hashes correspond ...
- And they don't...
- DO NOT USE THIS FILE!!! It is possibly infected/tampered/broken and we can no longer assume it is what the publisher originally intented to share
- Try re-downloading the file, from another source if possible or contact the publisher to get more infos

>Example 3:
- Now let's say a trusted publisher upload a legit file and its computed SHA1 checksum
- You download the file, compute the SHA1 hash on your side and verify that the SHA1 hashes correspond ...
- And they do! :D
- You can finally be sure that the file you downloaded is the file the publisher uploaded. Enjoy!


I'd still want to point out that there are ways to get around authenticity of a file and fool hash checking, with for example collision attacks on a compromised uploaded file. You can minimize the risk of this kind of attack by comparing many different checksums (according that they are provided by the publisher) but in the end, it will be more secure if the publisher digitally sign the checksum, ensuring only him could upload this file & hash & signature combination is what was intented to be transmitted, by the person who we thought it was.

HOW TO INSTALL
==============
Standalone executable.
Just grab HashChecker.exe and launch it.

As a .Net program, it currently only supports Windows Operating system.

At the time of this writing, the program has been tested on Linux through wine and seems to work correctly. However no support will be officially given for non-windows users. This software is planned to be ported to Java, wich will then be cross-plateform and allow full support for every common operating system.

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

 
 TO-DO
======
- Verify the hash case insensitively (a==A) ~Dun

- Create an 'uploader' section wich will compute and format all the hashes for a file publisher.

- Using the VirusTotal API (https://www.virustotal.com/en/documentation/public-api/) to get security infos about the submitted files on a third tab

