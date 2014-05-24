BCM2835
=======
Managed version (using PInvoke) of the C library for Broadcom BCM 2835 as used in Raspberry Pi.
The library imports all of the constants and methods.

More information: http://www.airspayce.com/mikem/bcm2835/

The solution was created using Visual Studio 2013 and the included unmanaged shared library is v1.36.
No need to build on the RPi but if you insist you can use the following command:
<pre>
# xbuild BCM2835.sln
</pre>

The ConsoleApplication1 project is a sample application to demonstrate use of the managed library.
