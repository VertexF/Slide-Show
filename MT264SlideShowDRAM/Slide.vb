Public Class Slide
    Private fImageLocation As String
    Private fText As String

    Public ReadOnly Property ImageLocation As String
        Get
            Return fImageLocation
        End Get
    End Property

    Public ReadOnly Property Text As String
        Get
            Return fText
        End Get
    End Property

    ''' <summary>
    ''' A new instance of Slide is created with ImageLocation and 
    ''' Text set to the empty string.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        fImageLocation = ""
        fText = ""
    End Sub

    ''' <summary>
    ''' A new instance of Slide is created with ImageLocation and 
    ''' Text set to loc and desc respectively.
    ''' </summary>
    ''' <param name="loc"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal loc As String, ByVal desc As String)
        fImageLocation = loc
        fText = desc
    End Sub
End Class
