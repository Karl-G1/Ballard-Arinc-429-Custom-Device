	## Ballard ARINC 429 Custom Device ##

**Ballard ARINC-429 Custom Device** allows users to use the [Ballard ARINC 429 devices](http://www.ni.com/en-ca/shop/select/pxi-arinc-429-interface-module) inside NI VeriStand. This is an avionic interface bus standard. It's important to note that supported hardware are the "NI-Keyed boards only", product Part Number should have the form: “LV-222-###-###”. Only 441 and 442 core models are supported.


### LabVIEW Version ###

LabVIEW 2016

### Built Availability ###

Builds available for VeriStand 2016 , 2017 , 2018 & 2019 under releases.

### Quality, Limitations ###

This IP is new. 

### Built Dependencies ###

[Astronics Ballard LabVIEW Driver 1.2.0.2 or Higher] http://www.ni.com/download/ballard-pxie-omnibus-ii-1.2.0/8336/en/

### Source Dependencies ###

[Astronics Ballard LabVIEW Driver 1.2.0.2 or Higher] http://www.ni.com/download/ballard-pxie-omnibus-ii-1.2.0/8336/en/

[OpenG Array Library 4.1.1.14 or Higher] vipm://oglib_array?repo_url=http://www.jkisoft.com/packages

[OpenG MD5 Digest Library 4.1.1.10 or Higher] vipm://oglib_md5?repo_url=http://www.jkisoft.com/packages

[NI VeriStand Addon Inline-Async-APIs 1.0.0 or Higher] https://github.com/ni/niveristand-custom-device-inline-async-api/releases/tag/v1.0.0

VIs must be renamed in BTI429LV.lvlib to prevent naming collision during compilation see User Readme.rtf

### License ###

*This repository and any materials provided by NI therein are provided AS IS. NI DISCLAIMS ANY AND ALL LIABILITIES FOR AND MAKES NO WARRANTIES, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR  PARTICULAR PURPOSE, OR NON-INFRINGEMENT OF INTELLECTUAL PROPERTY. NI shall have no liability for any direct, indirect, incidental, punitive, special, or consequential damages for your use of the repository or any materials contained therein.*
