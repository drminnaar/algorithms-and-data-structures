# C# Data Structures and Algorithms

This is a repository of various data structures and algorithms that have been implemented using the C# programming language.

## Developed With

* [Visual Studio Code](https://code.visualstudio.com/) - A source code editor developed by Microsoft for Windows, Linux and macOS. It includes support for debugging, embedded Git control, syntax highlighting, intelligent code completion, snippets, and code refactoring

* [Dotnet Core](https://www.microsoft.com/net/learn/get-started) - .NET Core is a general purpose development platform maintained by Microsoft and the .NET community on GitHub. It is cross-platform, supporting Windows, macOS and Linux, and can be used in device, cloud, and embedded/IoT scenarios.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

The following software is required to be installed on your system:

* Dotnet 2.1.x

Type the following commands in the terminal to verify your node and npm versions

```bash
dotnet --version
```

### Install

Follow the following steps to get development environment running.

* Clone _'algorithms-and-data-structures'_ repository from GitHub

  ```bash
  git clone https://github.com/drminnaar/algorithms-and-data-structures.git
  ```

  _OR USING SSH_

  ```bash
  git clone git@github.com:drminnaar/algorithms-and-data-structures.git
  ```

* Restore project dependencies (packages)

  ```bash
  cd algorithms-and-data-structures/csharp-ads/src
  dotnet restore
  ```

* Build

  ```bash
  cd algorithms-and-data-structures/csharp-ads/src
  dotnet build
  ```

### Running Tests

To run all tests in the project, type the following command:

```bash
cd algorithms-and-data-structures/csharp-ads/src/ADS.AlgorithmsTests
dotnet test
```

Furthermore, each algorithm or data structure will have it's own test.

For example:

* Change to test directory

   ```bash
   cd algorithms-and-data-structures/csharp-ads/src/ADS.AlgorithmsTests
   ```

* Run _'Bubble Sort'_ Test

  ```bash
  dotnet test --filter ClassName=ADS.AlgorithmsTests.BubbleSortTest
  ```

* Run _'Selection Sort'_ Test

  ```bash
  dotnet test --filter ClassName=ADS.AlgorithmsTests.SelectionSortTest
  ```

* Run _'Insertion Sort'_ Test

  ```bash
  dotnet test --filter ClassName=ADS.AlgorithmsTests.InsertionSortTest
  ```

## Visual Studio Code Extensions for C# Development

The following Visual Studio Code extensions should be installed for the best C# development experience.

### C# for Visual Studio Code [MANDATORY]

[More Info](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

#### Installation

Launch VS Code Quick Open (Ctrl+P), paste the following command, and press enter.

```bash
ext install ms-vscode.csharp
```

### C# IDE Extensions for VSCode

[More Info](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)

#### Installation

Launch VS Code Quick Open (Ctrl+P), paste the following command, and press enter.

```bash
ext install jchannon.csharpextensions
```

### Dotnet Test Explorer

[More Info](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)

#### Installation

Launch VS Code Quick Open (Ctrl+P), paste the following command, and press enter.

```bash
ext install formulahendry.dotnet-test-explorer
```

Press _Ctrl+,_ to open _'User Settings'_. Paste in the following setting to enable a tree view of all the tests.

```bash
"dotnet-test-explorer.testProjectPath": "./csharp-ads/src/ADS.AlgorithmsTests"
```

![dotnet-test-explorer](https://user-images.githubusercontent.com/33935506/40589267-8e551efe-61ea-11e8-9762-0d500a84063d.png)

![dotnet-test-explorer-test](https://user-images.githubusercontent.com/33935506/40589314-860da09e-61eb-11e8-8dcd-5af7d205dd14.png)