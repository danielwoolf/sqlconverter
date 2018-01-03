# sqlconverter

### Introduction
This code was [originally published by Liron Levi](http://www.codeproject.com/Articles/26932/Convert-SQL-Server-DB-to-SQLite-DB) whose release notes are reproduced below. 
[jschultz](https://github.com/jschultz/) moved the source to github in order to facilitate ongoing development.
However, that repo has moved on to tackle SQLite -> SQL Server conversion.
This fork focusses on fixing some of the bugs in core functionality of the original SQL Server -> SQLite conversion.

### History

    13th June, 2008: Initial version
    08th July, 2008: v 1.2
        Fixed a bug that caused unique indexes to be generated as non-unique in some cases
    08th July, 2008: v 1.3
        Fixed a bug that caused the utility to crash sometimes when processing index information
    17th July, 2008: v 1.4
        Fixed a bug that caused wrong columns to become primary keys on rare occasions and improved conversion performance
    20th July, 2008: v 1.5
        Added support for case-insensitive columns (COLLATE NOCASE)
    22nd July, 2008: v 1.6
        Added support for encrypting the resulting DB file (using the built-in encryption support that exists in the SQLite .NET provider)
    05th October, 2008: v 1.7
        Fixed information_schema references to use UPPER-CASE in order to resolve international character set issues (Turkish)
    14th December 2008: v1.8
        Integrated support for foreign keys from the revised version made by Yogesh Jagota
        Merged support for selective table import
    21st February 2009: v1.9
        Added contribution from johnny dickson cano that allows to select using SQL server integrated security or using user name /password instead
        Added support for converting IDENTITY columns to AUTOINCREMENT in SQLite (suggestion by Paul Shaffer)
    04th March 2009: v1.10
        Fixed a bug that caused the converter to crash when encountering a datetime field in the original SQL server schema. Thanks to bmcclint for sending me the bug with the correct bugfix.
    23rd May 2009: v1.11
        Added support for simulating foreign keys using triggers (contributed by Martijn Muurman)
        Added a small bugfix so that now an 'int' type is always converted to 'integer' type in sqlite. This was needed because sqlite will autoincrement only on 'integer' column types.
    04th June 2009: v1.12
        Fixed a bug in trigger generation code that caused schema generation to fail when more than a single column is referencing the same column in a foreign table
    20th September 2009: v1.13
        Fixed AUTOINCREMENT bug suggested by MAEP
        Fixed 64 bit support problem (thanks to Murry Gammash)
        Added support for converting SQL Server views (suggested by Richard Thurgood)
    22nd September 2009: v1.14
        Fixed a critical bug that caused the conversion process to fail on some SQL Server databases that used the [dbo] notation.
    25th September 2009: v1.15
        Fixed a critical bug that caused the primary keys to be discarded
        Fixed trigger generation bug
    4th December 2009: v1.16
        Fixed generation code to create GUID types for SQL-Server's uniqueidentifier type (instead of nvarchar as it was until now)
        Updated the solution to use the latest SQLite .NET provider library
    24th March, 2011
        Attached compiled version of the project for anyone that doesn't have Visual Studio and still needs to use the utility
    1st July, 2011
        Updated binary zip as the earlier one was missing the DLL file needed by the application
    15th Nov 2011: v1.17
        Fixed a bug that caused the software to crash when encountering NULL values in some of SQL Server meta data tables
    19th June 2012: v1.19
        Added support for ignoring views when creating the DB schema, Added support for blank characters inside column names.
    14th January 2013: v1.20
        Fixed problem with column names
        Added more width to the database names combo box. 
    3rd January 2018: v1.30
        Forked from https://github.com/jschultz/sqlconverter
        Reset commit to 4c42c27 (original version from codeproject)
        Fixed issue where primary keys were not being created on non-dbo schemas
        Tidied UI
