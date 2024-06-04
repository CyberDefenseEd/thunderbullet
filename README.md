# ThunderBullet [![Build status](https://ci.appveyor.com/api/projects/status/ubdcnn38uanaoqic?svg=true)](https://ci.appveyor.com/project/CyberDefenseEd/thunderbullet)
--- 
<div align="center">
  <img src="https://files.catbox.moe/y9wquc.png">
</div>

---

ThunderBullet is a comprehensive web testing suite designed for performing requests on target web applications and offering a wide array of tools to analyze and work with the results. This software facilitates tasks such as data scraping, parsing, automated penetration testing, and unit testing utilizing Selenium, among other functionalities.

**IMPORTANT!** It is crucial to note that engaging in (D)DoS attacks or credential stuffing on websites without proper authorization is illegal. The developer cannot be held liable for any misuse of this software.


[Here](https://ThunderBullet.github.io/ob1), you can access the complete documentation covering usage guidelines, configuration setup, and the RuriLib API.

The **ThunderBullet API** has been introduced, enabling the hosting of configurations remotely on your server. This feature allows ThunderBullet to download updated configurations during rescans, ensuring consistency across different systems or users. Learn more about it [here](https://ThunderBullet.github.io/ob1/remote.html).

Encountered a bug? [Report it here](https://help.github.com/en/articles/creating-an-issue).

# How to Build

0. Ensure you have installed the .NET framework (dev) 4.7.2 or later.
1. **Clone this repository** and open the solution file using Visual Studio.
2. Switch to **Release** mode for a cleaner output.
3. **Build** the solution (Visual Studio will fetch any missing NuGet packages).
4. Executables can be found within the ThunderBullet/bin/Release and ThunderBulletCLI/bin/Release directories.

# License

This software is distributed under the MIT License.

--- 
