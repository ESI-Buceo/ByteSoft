﻿'''<summary>
'''Clase encargada de las consultas pertenecientes a las patologías.
'''</summary>
Public Class ModeloPatologia
    Inherits Conexion

    '''<summary>
    '''Consulta encargada de registrar las patologías.
    '''</summary>
    Public Function Registrar(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, nomSintomas As ArrayList) As Boolean

        Command.CommandText = "INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ('" & nombre & "','" & descripcion & "','" & recomendacion & "','" & prioridad & "')"
        abrirConexion()
        Command.ExecuteNonQuery()

        For Each nom In nomSintomas
            Command.CommandText = "
                    INSERT INTO patologia_contiene_sintoma (idSintoma, idPatologia)
                    VALUES
                        ((SELECT
                            idSintoma
                        FROM
                            sintoma
                        WHERE
                            nombre = '" & nom & "'),
                        (SELECT
                            idPatologia
                        FROM
                            patologia
                        WHERE
                            nombre = '" & nombre & "'))"

            Command.ExecuteNonQuery()
            cerrarConexion()
        Next

        Return True
    End Function

    '''<summary>
    '''Consulta encargada de listar las patologías.
    '''</summary>
    Public Function listarPatologias() As DataTable

        Dim dt As New DataTable
        Command.CommandText = "SELECT nombre AS Nombre, descripcion AS Descripcion, recomendacion AS Recomendacion, prioridad AS Prioridad FROM patologia"
        abrirConexion()
        dt.Load(Command.ExecuteReader())
        cerrarConexion()

        Return dt
    End Function

    '''<summary>
    '''Consulta encargada de eliminar patologías.
    '''</summary>
    Public Function eliminarPatologias(ali As ArrayList) As Boolean

        Dim parametros As String
        Dim consulta As String = "
            DELETE patologia_contiene_sintoma , patologia  
            FROM patologia_contiene_sintoma  
            INNER JOIN patologia  
                WHERE patologia_contiene_sintoma.idPatologia = patologia.idPatologia AND
                patologia_contiene_sintoma.idPatologia = patologia.idPatologia
                AND patologia.nombre IN ("

        For i = 0 To ali.Count - 1

            parametros = parametros & "'" & ali.Item(i) & "'" & ","
        Next

        consulta = consulta & parametros.TrimEnd(",") & ")"

        Command.CommandText = consulta
        Command.ExecuteNonQuery()
        cerrarConexion()

        Return True
    End Function

    '''<summary>
    '''Consulta encargada de obtener las patologías asociadas a los síntomas ingresador por el paciente.
    '''</summary>
    Public Function obtenerPatologia(sintomas As ArrayList) As DataTable

        Dim dt As New DataTable
        Dim parametros As String
        Dim consulta As String = "
           SELECT p.nombre, p.descripcion
           FROM patologia p, sintoma s, patologia_contiene_sintoma ps
           WHERE p.idPatologia = ps.idPatologia and s.idSintoma = ps.idSintoma 
           and s.nombre IN ("

        For i As Integer = 0 To sintomas.Count - 1

            parametros = parametros & "'" & sintomas.Item(i) & "'" & ","

        Next

        consulta = consulta & parametros.TrimEnd(",") & ")"
        consulta = consulta & " GROUP BY ps.idPatologia ORDER BY count(*) desc"

        Command.CommandText = consulta

        dt.Load(Command.ExecuteReader())
        cerrarConexion()

        Return dt
    End Function

End Class
