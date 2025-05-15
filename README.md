# UBL Invoice Parsing with C\#

This project demonstrates how to parse UBL (Universal Business Language) Invoice XML files using C# and the **UBLSharp** library.

## Overview

* **XML Structure**: The invoice XML follows the UBL 2.1 standard with proper namespace declarations (`xmlns` attributes).
* **Key Elements**: Includes Invoice ID, Issue Date, Supplier Party, and Payable Amount with currency attribute.
* **Deserialization**: Utilizes `XmlSerializer` with `InvoiceType` from the UBLSharp package to deserialize XML into C# objects.
* **Output**: Displays core invoice details in the console.

## Setup & Usage

1. Add UBLSharp package:

   ```bash
   dotnet add package UblSharp
   ```

2. Place the provided `invoice.xml` file in the project directory.

3. Run the C# program (`Program.cs`) to deserialize and print invoice data.

## Key Points

* Ensure XML namespaces (`xmlns`) are correctly defined for successful deserialization.
* The program extracts essential invoice fields such as `ID`, `IssueDate`, supplier `Name`, and `PayableAmount` with currency.
