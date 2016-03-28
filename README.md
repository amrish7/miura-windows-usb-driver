# Introduction
This repository contains USB driver for Miura EMV Reader (M010) and windows installer project that installs the driver files (INF & CAT) and the [Microsoft Driver Package Installer redistributable] (https://msdn.microsoft.com/en-us/library/windows/hardware/ff544842%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396) for x86 and x64 versions of Windows.

# Preparing the Catalog file
The catalog files on this repository were created using the `inf2cat` utility. Following are the steps to re-create CAT file
  * Install [Windows 7 WDK] (https://www.microsoft.com/en-us/download/details.aspx?id=11800)
  * Open the `build` prompt forfrom Win7 WDK (Search for `x64 checked build environment`) with admin privileges
  * Execute `inf2cat /driver:{PATH_TO_FOLDER_CONTAINING_INF_FILE} /os:7_x64, 7_X86, XP_X64, XP_X86` by adding all relevant target OS. (See [this link] (https://msdn.microsoft.com/en-us/library/windows/hardware/ff547089(v=vs.85).aspx) for full list of versions)
    * `inf2cat` would be located in `C:\WinDDK\7600.16385.1\bin\selfsign\Inf2Cat.exe`

# Signing the driver package
* Copy the code signing certificate to the folder that has the `inf` and generated `cat` file
* Execute the command `SignTool sign /f {fileName} /p {password} /t http://timestamp.verisign.com/scripts/timstamp.dll m010.cat` from command prompt with admin privileges

# Installing the driver package
The `DriverInstaller` project is a windows console app that executes the `DPInst.exe` utility. The windows installer project takes care of copying the required installation files to the `\Program Files(x86)\` folder and automates the `DPInst.exe` command


