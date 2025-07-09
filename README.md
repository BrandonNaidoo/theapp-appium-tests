# AppiumTests - Mobile Test Automation with Appium & C#

---

## Build Status

| Service        | Status                                                                                                                                                                                                                                                 |
| -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **GitHub**     | [![GitHub Workflow Status](https://github.com/BrandonNaidoo/theapp-appium-tests/actions/workflows/ci.yml/badge.svg)](https://github.com/BrandonNaidoo/theapp-appium-tests/actions/workflows/ci.yml)
+
---

## Project Overview

This project demonstrates maintainable and scalable automated UI tests for Android native apps using:

- **Appium** as the mobile automation framework
- **C#** with **NUnit** as the test framework
- **Page Object Model (POM)** design pattern for test maintainability
- **FluentAssertions** for expressive assertions
- Support for running tests on Android Emulator with APK downloaded from the public repo

---

## Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with C# development workload
- [Android Studio](https://developer.android.com/studio) with Android Emulator installed and configured
- [Appium Server](https://appium.io/) installed and running (version 2.x recommended)

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/BrandonNaidoo/theapp-appium-tests.git
   cd theapp-appium-tests
   ```
1. Restore dependencies:
   ```bash
   dotnet restore
   ```
1. Launch your Android Emulator from Android Studio.
1. Start Appium Server (e.g., appium command or Appium Desktop).

---

## 🚀 Running Tests

Run all tests using the .NET CLI:

```bash
dotnet test
```

---

## 🧩 Project Structure

## Project Structure
```
theapp-appium-tests/
├── .editorconfig              # Code style and formatting rules
├── .gitignore                 # Files and folders to ignore in Git
├── AppiumTests.sln            # Visual Studio solution file
├── LICENSE                    # Project license (e.g. MIT)
├── README.md                  # Project documentation
│
├── AppiumTests/               # Main test project
│   ├── AppiumTests.csproj     # C# project file
│   ├── Framework/             # Core test infrastructure (e.g. TestBase)
│   ├── Models/                # Data models used in tests
│   ├── Pages/                 # Page Object Model (POM) classes
│   ├── TestData/              # Shared test data, enums, constants
│   ├── Tests/                 # NUnit test classes
│   └── Utils/                 # Utility/helper classes (e.g. ApkDownloader)
```
---

## ⚙️ CI/CD and Quality



---

## 🤝 Contributing

At this time, this project is not open to external contributions.

Please feel free to fork the repository for personal use or experimentation, but I am not currently accepting pull requests or feature suggestions.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 🙌 Acknowledgments

Thanks to [appium-pro](https://github.com/appium-pro) for providing a public Android app in the GitHub repository [appium-pro/TheApp](https://github.com/appium-pro/TheApp), which is used as the System Under Test (SUT) in this project.