Imports System.Drawing.Printing
Imports System.IO

Public Class SlideShowAdmin
    Inherits PrintDocument
    Private fSlides As List(Of Slide)
    Public Property Current As Integer

    ''' <summary>
    ''' An instance of SlideShowAdmin is created with the list of slides
    ''' set to a new empty list of slides and Current set to 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        fSlides = New List(Of Slide)
        Current = 0
    End Sub

    ''' <summary>
    ''' Preconditions: none
    ''' Postconditions: If the list of slides is not empty, an attempt is made to return
    ''' the image from the current slide. If the list is empty or the attempt fails,
    ''' Nothing is returned.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentImage As Image
        Get
            Dim result As Image
            result = Nothing
            Try
                result = Bitmap.FromFile(fSlides.Item(Current).ImageLocation)
            Catch ex As Exception
                'Nothing is returned.
            End Try
            Return result
        End Get
    End Property

    ''' <summary>
    ''' Preconditions: none
    ''' Postconditions: The text from the current slide is returned. If the list of
    ''' slides is empty then the empty string is returned.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CurrentText As String
        Get
            Dim result As String
            result = ""
            If fSlides.Count > Current Then
                result = fSlides.Item(Current).Text
            End If
            Return result
        End Get
    End Property

    ''' <summary>
    ''' Preconditions: none
    ''' Postconditions: Current is set to 0.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub firstSlide()
        Current = 0
    End Sub

    ''' <summary>
    ''' Preconditions: none
    ''' Postconditions: If Current + 1 is less than the number of slides,
    ''' Current is incremented by 1. Otherwise nothing is done.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nextSlide()
        If Current < fSlides.Count - 1 Then
            Current = Current + 1
        End If
    End Sub

    ''' <summary>
    ''' Preconditions: none
    ''' Postconditions: If Current is greater than zero then 
    ''' Current is decremented by 1. Otherwise nothing is done.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub previousSlide()
        If Current > 0 Then
            Current = Current - 1
        End If
    End Sub

    ''' <summary>
    ''' Preconditions: CurrentImage is not Nothing.
    ''' Postconditions: CurrentImage is drawn on g. For further details, see Q3(a).
    ''' </summary>
    ''' <param name="g"></param>
    ''' <remarks></remarks>
    Public Sub drawSlide(ByVal g As Graphics)
        Dim left As Single
        Dim top As Single
        Dim w As Single
        Dim h As Single
        Dim scale As Single
        Dim spaceW As Single
        Dim spaceH As Single
        spaceW = DefaultPageSettings.Bounds.Width
        spaceH = DefaultPageSettings.Bounds.Height
        If CurrentImage IsNot Nothing Then
            If spaceW / CurrentImage.Width < spaceH / CurrentImage.Height Then
                scale = spaceW / CurrentImage.Width
            Else
                scale = spaceH / CurrentImage.Height
            End If
            w = CurrentImage.Width * scale
            h = CurrentImage.Height * scale
            left = (spaceW - w) / 2
            top = (spaceH - h) / 2
            g.DrawImage(CurrentImage, left, top, w, h)
        End If
    End Sub
 
    ''' <summary>
    ''' Preconditions: none
    ''' Postconditions: An attempt is made to open the slide show found at filename.
    ''' If successful, Current is set to 0.
    ''' If the attempt fails, an exception is thrown.
    ''' </summary>
    ''' <param name="fileName"></param>]
    ''' <remarks></remarks>
    Public Sub openSlideShow(ByVal fileName As String)
        Dim aReader As StreamReader
        Dim path As String
        Dim index As Integer
        Dim aSlide As Slide
        path = ""
        index = fileName.LastIndexOf("\"c)
        If Not index = -1 Then
            path = fileName.Substring(0, index + 1)
        Else
            index = fileName.LastIndexOf("/"c)
            If Not index = -1 Then
                path = fileName.Substring(0, index + 1)
            End If
        End If
        fSlides.Clear()
        Try
            aReader = New StreamReader(fileName)
            While Not (aReader.EndOfStream())
                aSlide = New Slide(path + aReader.ReadLine(), aReader.ReadLine())
                fSlides.Add(aSlide)
            End While
            Current = 0
        Catch ex As Exception
            Throw New Exception("There was a problem reading from " + fileName)
        Finally
            If aReader IsNot Nothing Then
                aReader.Close()
            End If
        End Try
    End Sub
End Class
