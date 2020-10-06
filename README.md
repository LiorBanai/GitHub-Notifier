<h1 align="left">GitHub-Notifier <img src="./Assets/GitHubNotifier.jpg" align="right" width="63px" height="63px"></h1> 

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/2b86b59709a04b13991f5a4f3d775cb2)](https://app.codacy.com/gh/LiorBanai/GitHub-Notifier?utm_source=github.com&utm_medium=referral&utm_content=LiorBanai/GitHub-Notifier&utm_campaign=Badge_Grade)
  [![Nuget](https://img.shields.io/nuget/dt/LiorBanai.GitHubNotifier)](https://www.nuget.org/packages/LiorBanai.GitHubNotifier/) ![CodeQL](https://github.com/LiorBanai/GitHub-Notifier/workflows/CodeQL/badge.svg)  [![Build Status](https://liorbanai.visualstudio.com/GitHub-Notifier/_apis/build/status/LiorBanai.GitHub-Notifier?branchName=master)](https://liorbanai.visualstudio.com/GitHub-Notifier/_build/latest?definitionId=4&branchName=master)
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
