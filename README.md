# Introduction
This repository contains USB driver for Miura EMV Reader (M010) and windows installer project that installs the driver files (INF & CAT) and the [Microsoft Driver Package Installer redistributable] (https://msdn.microsoft.com/en-us/library/windows/hardware/ff544842%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396) for x86 and x64 versions of Windows.

# Preparing the Catalog file
The catalog files on this repository were created using the `inf2cat` utility
```
inf2cat /driver:{PATH_TO_INF_FILE} /os:7_x64
```
`inf2cat` came from [Windows 7 WDK] (https://www.microsoft.com/en-us/download/details.aspx?id=11800)

# Signing the driver package
Work In Progress...

# Installing the driver package
The `DriverInstaller` project is a windows console app that executes the `DPInst.exe` utility. The windows installer project takes care of copying the required installation files to the `\Program Files(x86)\` folder and automates the `DPInst.exe` command


