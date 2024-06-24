Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Common
    Public Shared myDBConnection As MySqlConnection

    Public Shared Function getDBConnectionX() As MySqlConnection

        myDBConnection = New MySqlConnection(
               "Database=projectDB;" &
                     "Data Source=localhost;" &
                    "User id= projectDBAdmin;" &
                    "Password= 1322LDSP;" &
                    "Port=3306;Command TimeOut=600;")
        Return myDBConnection

    End Function
End Class
