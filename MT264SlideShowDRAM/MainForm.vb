Imports MT264SlideShow1.SlideShowAdmin
Imports System.Drawing.Printing
Imports System.Drawing.Graphics

Public Class MainForm
    Private fSlideShowAdmin As SlideShowAdmin
    Private fGraphics As Graphics
    Private fPageNumber As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fSlideShowAdmin = New SlideShowAdmin
        fPageNumber = 0
    End Sub

    Private Sub updateView()
        'The picture box image is set to the current slide image.
        'The text box text is set to the current slide text.
        slidePictureBox.Image = fSlideShowAdmin.CurrentImage
        slideTextBox.Text = fSlideShowAdmin.CurrentText
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Resources are disposed of.
        fSlideShowAdmin.Dispose()
    End Sub

    Private Sub exitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitMenuItem.Click
        'The form is closed.
        Me.Close()
    End Sub

    Private Sub openMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openMenuItem.Click
        'The openSlideShow method of fSlideShowAdmin is invoked. If the slide show 
        'contains some slides, the image list and list view are populated with these slides.
        'If there is a problem opening the file, a message saying so is displayed to the user.
        If anOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                fSlideShowAdmin.openSlideShow(anOpenFileDialog.FileName)
                updateView()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub printPreviewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printPreviewMenuItem.Click
        'A dialogue box is displayed for previewing a print of the current slide image.
        fPageNumber = 1
        aPrintPreviewDialog.Document = PrintDocument1
        aPrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub printMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printMenuItem.Click
        'A dialogue box is displayed for printing the current slide image.
        fPageNumber = 1
        'This if statement checks to see if the document in the print preview been loaded.
        'This is useful because if the user changes the document inside print preview it will need to be printed the way the user has wanted to be.
        If aPrintPreviewDialog.Document IsNot Nothing Then
            aPrintDialog.Document = aPrintPreviewDialog.Document
        Else
            aPrintDialog.Document = PrintDocument1
        End If
        If aPrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fSlideShowAdmin.Print()
        End If
    End Sub

    Private Sub restartButton_Click(sender As System.Object, e As System.EventArgs) Handles restartButton.Click
        'Sends the user to the first slide.
        fSlideShowAdmin.firstSlide()
        updateView()
    End Sub

    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        'Sends the user to the next slide.
        fSlideShowAdmin.nextSlide()
        updateView()
    End Sub

    ''' Preconditions: The text needs to be loaded.
    ''' Postconditions: The size of the font has been increased by 4
    Private Sub zoomButton_Click(sender As System.Object, e As System.EventArgs) Handles zoomButton.Click
        'This method makes a new font and sets it to the original font.
        'After that we create a new font and increase the text size by 4, then updates.
        Dim CurrentSize As Single
        Dim CurrentFont As Font
        CurrentSize = slideTextBox.Font.Size
        CurrentFont = slideTextBox.Font
        slideTextBox.Font = New Font(CurrentFont.Name, CurrentSize + 4, FontStyle.Regular)
        updateView()
    End Sub

    Private Sub slidePictureBox_Click(sender As System.Object, e As System.EventArgs) Handles slidePictureBox.Click
        'Updates the slides and the text
        updateView()
    End Sub

    Private Sub slideTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles slideTextBox.TextChanged
        'Updates the slides and the text
        updateView()
    End Sub

    Private Sub previousButton_Click(sender As System.Object, e As System.EventArgs) Handles previousButton.Click
        'Sends the user to the previous slide.
        fSlideShowAdmin.previousSlide()
        updateView()
    End Sub


    Private Sub ChangeFontToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeFontToolStripMenuItem.Click
        'This method shows the new dialog box.
        'After the user has changed the font we change the font of the orginal text to what the user change the font to in the dialog box.
        aFontDialog.ShowDialog()
        slideTextBox.Font = aFontDialog.Font
        updateView()
    End Sub

    Private Sub ChangeColourToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeColourToolStripMenuItem.Click
        'This method shows the new dialog box.
        'After the user has changed the colour we change the foreground colour to what the user changed the colour to in the dialog box.
        aColorDialog.ShowDialog()
        slideTextBox.ForeColor = aColorDialog.Color
        updateView()
    End Sub

    Private Sub ChangeBackgroundColourToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangeBackgroundColourToolStripMenuItem.Click
        'This method shows the new dialog box.
        'After the user has changed the colour we change the background colour to what the user changed the colour to in the dialog box.
        aColorDialog.ShowDialog()
        slideTextBox.BackColor = aColorDialog.Color
        updateView()
    End Sub


    ''' Preconditions: None.
    ''' Postconditions: Takes the current images and applies it to the print preview page, which is what the user want to print.
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'This method handles drawing the image to the preview document.
        'It first checks the the total number of pages needed.
        Select Case fPageNumber
            Case 1
                'Here when we have one page we check to see if the image is not nothing if this is true we draw the slide.
                If fSlideShowAdmin.CurrentImage IsNot Nothing Then
                    fSlideShowAdmin.drawSlide(e.Graphics)
                End If
                'Here we tell the appliction there is no more pages, and we increment the page value by one.
                fPageNumber = fPageNumber + 1
                e.HasMorePages = True
            Case 2
                'Here we continue to update the Print Page if we have more than one page
                e.Graphics.PageUnit = GraphicsUnit.Pixel
                If fSlideShowAdmin.CurrentImage IsNot Nothing Then
                    fSlideShowAdmin.drawSlide(e.Graphics)
                End If
                fPageNumber = fPageNumber + 1
                e.HasMorePages = True
            Case 3
                e.Graphics.PageUnit = GraphicsUnit.Pixel
                e.Graphics.PageScale = 6
                If fSlideShowAdmin.CurrentImage IsNot Nothing Then
                    fSlideShowAdmin.drawSlide(e.Graphics)
                End If
                e.HasMorePages = False
        End Select
    End Sub
End Class
