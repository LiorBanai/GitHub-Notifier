<h1 align="left">GitHub-Notifier <img src="./Assets/GitHubNotifier.jpg" align="right" width="63px" height="63px"></h1> 

  [![Nuget](https://img.shields.io/nuget/dt/LiorBanai.GitHubNotifier)](https://www.nuget.org/packages/LiorBanai.GitHubNotifier/) ![CodeQL](https://github.com/LiorBanai/GitHub-Notifier/workflows/CodeQL/badge.svg) [![.NET Core Desktop](https://github.com/LiorBanai/GitHub-Notifier/actions/workflows/dotnet-core-desktop.yml/badge.svg)](https://github.com/LiorBanai/GitHub-Notifier/actions/workflows/dotnet-core-desktop.yml)
<a href="https://github.com/LiorBanai/GitHub-Notifier/issues">
    <img src="https://img.shields.io/github/issues/LiorBanai/GitHub-Notifier"  alt="Issues"/>
</a>
<a href="https://github.com/LiorBanai/GitHub-Notifier/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/LiorBanai/GitHub-Notifier"  alt="License"/>
</a>
   [![Nuget](https://img.shields.io/nuget/v/LiorBanai.GitHubNotifier)](https://www.nuget.org/packages/LiorBanai.GitHubNotifier/)
<a href="https://github.com/LiorBanai/GitHub-Notifier/releases"> 
    <img src="https://img.shields.io/github/v/release/LiorBanai/GitHub-Notifier"  alt="Latest Release"/>
</a> 
 <a href="https://github.com/LiorBanai/GitHub-Notifier/compare/V1.0.4...master">
    <img src="https://img.shields.io/github/commits-since/LiorBanai/GitHub-Notifier/latest"  alt="Commits Since Latest Release"/>
</a>
                                                                                                                           

                                                                                                                               
a small program that sits in the tray bar and periodically check repositories for activity.

![Main screen](Assets/screenshot4.jpg)

## How to use

1. Go to github user settings under https://github.com/settings/tokens
2. Create new token with permission for notifications, read:org, read:user, repo.
3. Add environment variable with key "GitHubNotifier_Token" (without the ") and value with the token from 2.
4. Run the app. if all is good you should see at the bottom screen "API limits: Remaining XX/5000
