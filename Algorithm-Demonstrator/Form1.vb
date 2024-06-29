Imports Utility_Functions
Imports Random_Number_Generator
Imports File_Handler
Imports Sorting_Algorithms
Imports Searching_Algorithms
Public Class Form1
    ' Importing Classes
    Private Utility_Functions As New Utility_Functions
    Private Random_Number_Generator As New Random_Number_Generator
    Private File_Handler As New File_Handler
    Private Sorting_Algorithms As New Sorting_Algorithms
    Private Searching_Algorithms As New Searching_Algorithm
    Private Sub TimerLoadingScreen_Tick(sender As Object, e As EventArgs) Handles TimerLoadingScreen.Tick
        ' Timer for the loading screen
        pnlBuffer.Width += 3
        If pnlBuffer.Width >= pnlLoaderLimit.Width Then
            pnlLoader.Visible = False
            pnlInputSelect.Visible = True
            TimerLoadingScreen.Dispose()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Stylize Buttons
        Utility_Functions.round_buttons_maker(cmdGenRndNumSelect, Color.Black, Color.White)
        Utility_Functions.round_buttons_maker(cmdImportNumSelect, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdImportNumSetBrowse, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdMainSelectBubbleSort, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdMainSelectInsertionSort, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdMainSelectLinearSearch, Color.Black, Color.White)
        Utility_Functions.round_buttons_maker(cmdMainSelectBinarySearch, Color.Black, Color.White)
        Utility_Functions.round_buttons_maker(cmdBubbleSortSort, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdInsertionSortSort, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdLinearSearchSearch, Color.White, Color.Black)
        Utility_Functions.round_buttons_maker(cmdBinarySearchSearch, Color.White, Color.Black)

        ' Clear the output labels in algorithm output interfaces
        lblBubbleSortOutput.Text = ""
        lblInsertionSortOutput.Text = ""
        lblLinearSearchOutput.Text = ""
        lblBinarySearchOutput.Text = ""

        ' Generate a Random Number Set
        Utility_Functions.random_array_container(Random_Number_Generator.generate_random_numbers(9))
        lblGeneratedNumberSet.Text = ""
        lblGeneratedNumberSet.Text = lblGeneratedNumberSet.Text & Utility_Functions.array_to_string(Utility_Functions.get_random_array())
    End Sub

    Private Sub cmdRefreshRndNumberSet_Click(sender As Object, e As EventArgs) Handles cmdRefreshRndNumberSet.Click
        ' Regenerate the number set when refresh button is pressed
        Utility_Functions.random_array_container(Random_Number_Generator.generate_random_numbers(9))
        lblGeneratedNumberSet.Text = ""
        lblGeneratedNumberSet.Text = lblGeneratedNumberSet.Text & Utility_Functions.array_to_string(Utility_Functions.get_random_array())
    End Sub

    Private Sub pnlInputSelectMover1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlInputSelectMover1.MouseDown
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(True)
    End Sub

    Private Sub pnlInputSelectMover1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlInputSelectMover1.MouseUp
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(False)
    End Sub

    Private Sub pnlInputSelectMover1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlInputSelectMover1.MouseMove
        'Code to make the interface movable
        If Utility_Functions.get_mouse_status() = True Then
            Dim iMouseX = MousePosition.X - 700
            Dim iMouseY = MousePosition.Y - 25
            Me.SetDesktopLocation(iMouseX, iMouseY)
        End If
    End Sub

    Private Sub pnlInputSelectMover2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlInputSelectMover2.MouseDown
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(True)
    End Sub

    Private Sub pnlInputSelectMover2_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlInputSelectMover2.MouseUp
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(False)
    End Sub

    Private Sub pnlInputSelectMover2_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlInputSelectMover2.MouseMove
        'Code to make the interface movable
        If Utility_Functions.get_mouse_status() = True Then
            Dim iMouseX = MousePosition.X - 700
            Dim iMouseY = MousePosition.Y - 25
            Me.SetDesktopLocation(iMouseX, iMouseY)
        End If
    End Sub

    Private Sub cmdImportNumSetBrowse_Click(sender As Object, e As EventArgs) Handles cmdImportNumSetBrowse.Click
        ' Code to take the file location from OpenFileDialog
        txtFileLocation.Text = ""
        txtFileLocation.Text = File_Handler.file_location(OpenFileDialogBrowser)
    End Sub

    Private Sub cmdGenRndNumSelect_Click(sender As Object, e As EventArgs) Handles cmdGenRndNumSelect.Click
        ' storing the random generated array in the array_to_sort array for processing
        Utility_Functions.store_array_to_sort(Utility_Functions.get_random_array())
        Utility_Functions.store_processed_array(Utility_Functions.get_random_array())

        '''
        Utility_Functions.store_input_array(Utility_Functions.get_random_array())

        ' Change the interface when clicked
        panel_to_display(pnlMainSelect)

        ' Fill the input labels 
        lblBubbleSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
        lblInsertionSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
        lblLinearSearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
        lblBinarySearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
    End Sub

    Private Sub pnlMainSelectMover1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMainSelectMover1.MouseDown
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(True)
    End Sub

    Private Sub pnlMainSelectMover1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlMainSelectMover1.MouseUp
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(False)
    End Sub

    Private Sub pnlMainSelectMover1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlMainSelectMover1.MouseMove
        'Code to make the interface movable
        If Utility_Functions.get_mouse_status() = True Then
            Dim iMouseX = MousePosition.X - 700
            Dim iMouseY = MousePosition.Y - 25
            Me.SetDesktopLocation(iMouseX, iMouseY)
        End If
    End Sub

    Private Sub pnlMainSelectMover2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMainSelectMover2.MouseDown
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(True)
    End Sub

    Private Sub pnlMainSelectMover2_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlMainSelectMover2.MouseUp
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(False)
    End Sub

    Private Sub pnlMainSelectMover2_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlMainSelectMover2.MouseMove
        'Code to make the interface movable
        If Utility_Functions.get_mouse_status() = True Then
            Dim iMouseX = MousePosition.X - 700
            Dim iMouseY = MousePosition.Y - 25
            Me.SetDesktopLocation(iMouseX, iMouseY)
        End If
    End Sub

    Private Sub cmdMinimize1_Click(sender As Object, e As EventArgs) Handles cmdMinimize1.Click
        'Code to make the minimize button
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub cmdClose1_Click(sender As Object, e As EventArgs) Handles cmdClose1.Click
        'Code to make the close button with user validation
        If Utility_Functions.exit_program = True Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdMinimize2_Click(sender As Object, e As EventArgs) Handles cmdMinimize2.Click
        'Code to make the minimize button
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub cmdClose2_Click(sender As Object, e As EventArgs) Handles cmdClose2.Click
        'Code to make the close button with user validation
        If Utility_Functions.exit_program = True Then
            Me.Close()
        End If
    End Sub

    Private Sub pnlAlgorithmOutputMover1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlAlgorithmOutputMover1.MouseDown
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(True)
    End Sub

    Private Sub pnlAlgorithmOutputMover1_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlAlgorithmOutputMover1.MouseUp
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(False)
    End Sub

    Private Sub pnlAlgorithmOutputMover1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlAlgorithmOutputMover1.MouseMove
        'Code to make the interface movable
        If Utility_Functions.get_mouse_status() = True Then
            Dim iMouseX = MousePosition.X - 700
            Dim iMouseY = MousePosition.Y - 25
            Me.SetDesktopLocation(iMouseX, iMouseY)
        End If
    End Sub

    Private Sub pnlAlgorithmOutputMover2_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlAlgorithmOutputMover2.MouseDown
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(True)
    End Sub

    Private Sub pnlAlgorithmOutputMover2_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlAlgorithmOutputMover2.MouseUp
        'Code to make the interface movable
        Utility_Functions.mouse_state_store(False)
    End Sub

    Private Sub pnlAlgorithmOutputMover2_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlAlgorithmOutputMover2.MouseMove
        'Code to make the interface movable
        If Utility_Functions.get_mouse_status() = True Then
            Dim iMouseX = MousePosition.X - 700
            Dim iMouseY = MousePosition.Y - 25
            Me.SetDesktopLocation(iMouseX, iMouseY)
        End If
    End Sub

    Private Sub cmdMinimize3_Click(sender As Object, e As EventArgs) Handles cmdMinimize3.Click
        'Code to make the minimize button
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub cmdClose3_Click(sender As Object, e As EventArgs) Handles cmdClose3.Click
        'Code to make the close button with user validation
        If Utility_Functions.exit_program = True Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdBack1_Click(sender As Object, e As EventArgs) Handles cmdBack1.Click
        'Code to make the back/return button in the algorithm selection screen

        ' change the required interfaces
        pnlMainSelect.Visible = False
        pnlInputSelect.Visible = True

        ' Reseting the status of the processed algorithms
        Utility_Functions.store_bubble_sort_performed_status(False)
        Utility_Functions.store_insertion_sort_performed_status(False)

        ' Reseting the steps
        libxBinarySearchSteps.Items.Clear()
        libxBubbleSortSteps.Items.Clear()
        libxInsertionSortSteps.Items.Clear()
        libxLinearSearchSteps.Items.Clear()

        ' Reseting the algorithm outputs
        lblBubbleSortOutput.Text = ""
        lblInsertionSortOutput.Text = ""
        lblLinearSearchOutput.Text = ""
        lblBinarySearchOutput.Text = ""

        ' Reseting the previous search targets
        txtBinarySearch.Text = ""
        txtLinearSearch.Text = ""

        ' Reseting the radio buttons
        rbtnBubbleSortOption1.Checked = True
        rbtnInsertionSortOption1.Checked = True
        rbtnLinearSearchOption1.Checked = True
        rbtnBinarySearchOption1.Checked = True

    End Sub

    Private Sub cmdBack2_Click(sender As Object, e As EventArgs) Handles cmdBack2.Click
        'Code to make the back/return button in the algorithm output interface
        pnlMainSelect.Visible = True
        pnlAlgorithmOutput.Visible = False
        pnlInputSelect.Visible = False
    End Sub

    Private Sub cmdImportNumSelect_Click(sender As Object, e As EventArgs) Handles cmdImportNumSelect.Click
        If File_Handler.file_validator(txtFileLocation.Text) = True Then
            ' Read the File
            Utility_Functions.store_array_to_sort(File_Handler.read_file(txtFileLocation.Text))
            Utility_Functions.store_processed_array(File_Handler.read_file(txtFileLocation.Text))

            '''
            Utility_Functions.store_input_array(File_Handler.read_file(txtFileLocation.Text))

            Dim Msgboxtext As String
            Msgboxtext = "Valid File, " & vbCrLf & "File Content : " & Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
            MessageBox.Show(Msgboxtext, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Load the other panel (Main Input Selct Panel)
            panel_to_display(pnlMainSelect)

            ' Setting the input labels in algorithm output interfaces
            lblBubbleSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
            lblInsertionSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
            lblLinearSearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
            lblBinarySearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
        End If
    End Sub

    ' Subroutine to handle interface visibility
    Public Sub panel_to_display(ByVal input_panel As Panel)
        If input_panel.Name = pnlLoader.Name Then
            pnlLoader.Visible = True
            pnlInputSelect.Visible = False
            pnlAlgorithmOutput.Visible = False
            pnlMainSelect.Visible = False

        ElseIf input_panel.Name = pnlMainSelect.Name Then
            pnlLoader.Visible = False
            pnlInputSelect.Visible = False
            pnlAlgorithmOutput.Visible = False
            pnlMainSelect.Visible = True

        ElseIf input_panel.Name = pnlInputSelect.Name Then
            pnlLoader.Visible = False
            pnlInputSelect.Visible = True
            pnlAlgorithmOutput.Visible = False
            pnlMainSelect.Visible = False

        ElseIf input_panel.Name = pnlAlgorithmOutput.Name Then
            pnlLoader.Visible = False
            pnlInputSelect.Visible = False
            pnlAlgorithmOutput.Visible = True
            pnlMainSelect.Visible = False
        End If
    End Sub

    ' sub routine to handle algorithm output interfaces
    Public Sub algorithm_panel_to_display(ByVal input_panel As Panel)
        If input_panel.Name = pnlBubbleSort.Name Then
            pnlSidePanel.Visible = True

            pnlOnBubbleSortSelected.Visible = True
            pnlOnInsertionSortSelected.Visible = False
            pnlOnLinearSearchSelected.Visible = False
            pnlOnBinarySearchSelected.Visible = False

            pnlBubbleSort.Visible = True
            pnlInsertionSort.Visible = False
            pnlLinearSearch.Visible = False
            pnlBinarySearch.Visible = False

        ElseIf input_panel.Name = pnlInsertionSort.Name Then
            pnlSidePanel.Visible = True

            pnlOnBubbleSortSelected.Visible = False
            pnlOnInsertionSortSelected.Visible = True
            pnlOnLinearSearchSelected.Visible = False
            pnlOnBinarySearchSelected.Visible = False

            pnlBubbleSort.Visible = False
            pnlInsertionSort.Visible = True
            pnlLinearSearch.Visible = False
            pnlBinarySearch.Visible = False

        ElseIf input_panel.Name = pnlLinearSearch.Name Then
            pnlSidePanel.Visible = True

            pnlOnBubbleSortSelected.Visible = False
            pnlOnInsertionSortSelected.Visible = False
            pnlOnLinearSearchSelected.Visible = True
            pnlOnBinarySearchSelected.Visible = False

            pnlBubbleSort.Visible = False
            pnlInsertionSort.Visible = False
            pnlLinearSearch.Visible = True
            pnlBinarySearch.Visible = False

        ElseIf input_panel.Name = pnlBinarySearch.Name Then
            pnlSidePanel.Visible = True

            pnlOnBubbleSortSelected.Visible = False
            pnlOnInsertionSortSelected.Visible = False
            pnlOnLinearSearchSelected.Visible = False
            pnlOnBinarySearchSelected.Visible = True

            pnlBubbleSort.Visible = False
            pnlInsertionSort.Visible = False
            pnlLinearSearch.Visible = False
            pnlBinarySearch.Visible = True
        End If
    End Sub

    Private Sub cmdMainSelectBubbleSort_Click(sender As Object, e As EventArgs) Handles cmdMainSelectBubbleSort.Click
        ' Code to handle the algorithm output interface panel visibilities
        panel_to_display(pnlAlgorithmOutput)
        algorithm_panel_to_display(pnlBubbleSort)
    End Sub

    Private Sub cmdMainSelectLinearSearch_Click(sender As Object, e As EventArgs) Handles cmdMainSelectLinearSearch.Click
        ' Code to handle the algorithm output interface panel visibilities
        panel_to_display(pnlAlgorithmOutput)
        algorithm_panel_to_display(pnlLinearSearch)
    End Sub

    Private Sub cmdMainSelectInsertionSort_Click(sender As Object, e As EventArgs) Handles cmdMainSelectInsertionSort.Click
        ' Code to handle the algorithm output interface panel visibilities
        panel_to_display(pnlAlgorithmOutput)
        algorithm_panel_to_display(pnlInsertionSort)
    End Sub

    Private Sub cmdMainSelectBinarySearch_Click(sender As Object, e As EventArgs) Handles cmdMainSelectBinarySearch.Click
        ' Code to handle the algorithm output interface panel visibilities
        panel_to_display(pnlAlgorithmOutput)
        algorithm_panel_to_display(pnlBinarySearch)
    End Sub

    Private Sub cmdSelectBubbleSort_Click(sender As Object, e As EventArgs) Handles cmdSelectBubbleSort.Click
        ' Code to handle the algorithm output interface panel visibilities
        algorithm_panel_to_display(pnlBubbleSort)
    End Sub

    Private Sub cmdInsertionSort_Click(sender As Object, e As EventArgs) Handles cmdInsertionSort.Click
        ' Code to handle the algorithm output interface panel visibilities
        algorithm_panel_to_display(pnlInsertionSort)
    End Sub

    Private Sub cmdLinearSearch_Click(sender As Object, e As EventArgs) Handles cmdLinearSearch.Click
        ' Code to handle the algorithm output interface panel visibilities
        algorithm_panel_to_display(pnlLinearSearch)
    End Sub

    Private Sub cmdBinarySearch_Click(sender As Object, e As EventArgs) Handles cmdBinarySearch.Click
        ' Code to handle the algorithm output interface panel visibilities
        algorithm_panel_to_display(pnlBinarySearch)
    End Sub

    Private Sub cmdBubbleSortSort_Click(sender As Object, e As EventArgs) Handles cmdBubbleSortSort.Click
        ' Code for calling bubble sort function

        ' Create a new array to parse as input for the bubble sort function
        Dim Array_to_Bubble_Sort(UBound(Utility_Functions.get_array_to_sort)) As Integer
        Array_to_Bubble_Sort = Utility_Functions.duplicate_array(Utility_Functions.get_input_array)

        ' Checking whether it has been already processed
        If Utility_Functions.get_bubble_sort_performed_status = False Then
            ' If it is not processed the bubble sort function is called
            Sorting_Algorithms.bubble_sort(Array_to_Bubble_Sort, lblBubbleSortOutput, libxBubbleSortSteps)
            Utility_Functions.store_processed_array(Array_to_Bubble_Sort)

            ' setting the processed status as TRUE
            Utility_Functions.store_bubble_sort_performed_status(True)
        End If
    End Sub

    Private Sub cmdInsertionSortSort_Click(sender As Object, e As EventArgs) Handles cmdInsertionSortSort.Click
        ' Code for calling bubble sort function

        ' Create a new array to parse as input for the insertion sort function
        Dim Array_to_Insertion_Sort(UBound(Utility_Functions.get_array_to_sort)) As Integer
        Array_to_Insertion_Sort = Utility_Functions.duplicate_array(Utility_Functions.get_input_array)

        ' Checking whether it has been already processed
        If Utility_Functions.get_insertion_sort_performed_status = False Then
            ' If it is not processed the insertion sort function is called.
            Sorting_Algorithms.insertion_sort(Array_to_Insertion_Sort, lblInsertionSortOutput, libxInsertionSortSteps)
            Utility_Functions.store_processed_array(Array_to_Insertion_Sort)

            ' setting the processed status as TRUE
            Utility_Functions.store_insertion_sort_performed_status(True)
        End If
    End Sub

    Private Sub cmdLinearSearchSearch_Click(sender As Object, e As EventArgs) Handles cmdLinearSearchSearch.Click
        ' Code for calling linear search function

        ' Exception handling for invalid search targets
        Try
            Dim stTarget As String = txtLinearSearch.Text

            ' Check whether the search target is null or empty
            If String.IsNullOrEmpty(stTarget) = True Then
                MessageBox.Show("Invalid Target, Enter a valid target", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Casting the search target ("string") to an integer
                Dim iTarget = CInt(stTarget)
                If rbtnLinearSearchOption1.Checked = True Then
                    Searching_Algorithms.linear_search(Utility_Functions.get_array_to_sort, iTarget, lblLinearSearchOutput, libxLinearSearchSteps)
                ElseIf rbtnLinearSearchOption2.Checked = True Then
                    Searching_Algorithms.linear_search(Utility_Functions.get_processed_array, iTarget, lblLinearSearchOutput, libxLinearSearchSteps)
                End If
            End If
            ' Handling exceptions 
        Catch ex As Exception
            MessageBox.Show("Invalid Target, Enter a valid target", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdBinarySearchSearch_Click(sender As Object, e As EventArgs) Handles cmdBinarySearchSearch.Click
        ' Exception handling
        Try
            Dim stTarget As String = txtBinarySearch.Text

            ' Check whether the search target is null or empty
            If String.IsNullOrEmpty(stTarget) = True Then
                MessageBox.Show("Invalid Target, Enter a valid target", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                libxBinarySearchSteps.Items.Clear()
                libxBinarySearchSteps.Items.Add("Original Array: " & Utility_Functions.array_to_string(Utility_Functions.get_input_array))
                Dim iTarget = CInt(stTarget) ' Casting the search target ("string") to an integer
                Searching_Algorithms.binary_search(Utility_Functions.get_input_array, iTarget, lblBinarySearchOutput)

                ' Check whether the search target present in the number set 
                If lblBinarySearchOutput.Text = "Didn't find your target" Then
                    ' If search target is not present Steps are not displayed
                Else
                    ' If search target is present Steps are displayed
                    Try
                        Searching_Algorithms.binary_search_steps(Utility_Functions.get_input_array, iTarget, libxBinarySearchSteps)
                    Catch ex As Exception

                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Target, Enter a valid target", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        ' Code for the help button
        Dim Result As DialogResult
        Result = MessageBox.Show("Do you want to go to the help page ?", "Help?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' code to redirect to the help page
        If Result = DialogResult.Yes Then
            Help.ShowHelp(lblhelp, "https://blog.vishalrashmika.me/blog/algorithm-demonstrator-guide/")
        End If
    End Sub

    Private Sub rbtnBubbleSortOption1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBubbleSortOption1.CheckedChanged
        ' code to handle the input to bubble sort function
        If rbtnBubbleSortOption1.Checked = True Then
            Utility_Functions.store_bubble_sort_performed_status(False)
            Utility_Functions.store_input_array(Utility_Functions.get_array_to_sort)
            lblBubbleSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_input_array)
        End If
    End Sub

    Private Sub rbtnBubbleSortOption2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBubbleSortOption2.CheckedChanged
        ' code to handle the input to bubble sort function
        If rbtnBubbleSortOption2.Checked = True Then
            Utility_Functions.store_bubble_sort_performed_status(False)
            Utility_Functions.store_input_array(Utility_Functions.get_processed_array)
            lblBubbleSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_input_array)
        End If
    End Sub

    Private Sub rbtnInsertionSortOption1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnInsertionSortOption1.CheckedChanged
        ' code to handle the input to insertion sort function
        If rbtnInsertionSortOption1.Checked = True Then
            Utility_Functions.store_insertion_sort_performed_status(False)
            Utility_Functions.store_input_array(Utility_Functions.get_array_to_sort)
            lblInsertionSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_input_array)
        End If
    End Sub

    Private Sub rbtnInsertionSortOption2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnInsertionSortOption2.CheckedChanged
        ' code to handle the input to insertion sort function
        If rbtnInsertionSortOption2.Checked = True Then
            Utility_Functions.store_insertion_sort_performed_status(False)
            Utility_Functions.store_input_array(Utility_Functions.get_processed_array)
            lblInsertionSortInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_input_array)
        End If
    End Sub

    Private Sub rbtnLinearSearchOption1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLinearSearchOption1.CheckedChanged
        ' code to handle the input to linear search function
        If rbtnLinearSearchOption1.Checked = True Then
            lblLinearSearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_array_to_sort)
        End If
    End Sub

    Private Sub rbtnLinearSearchOption2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLinearSearchOption2.CheckedChanged
        ' code to handle the input to linear search function
        If rbtnLinearSearchOption2.Checked = True Then
            lblLinearSearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_processed_array)
        End If
    End Sub

    Private Sub rbtnBinarySearchOption1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBinarySearchOption1.CheckedChanged
        ' code to handle the input to binary search function
        If rbtnBinarySearchOption1.Checked = True Then
            Utility_Functions.store_input_array(Utility_Functions.get_array_to_sort)
            lblBinarySearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_input_array)
        End If
    End Sub

    Private Sub rbtnBinarySearchOption2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBinarySearchOption2.CheckedChanged
        ' code to handle the input to binary search function
        If rbtnBinarySearchOption2.Checked = True Then
            Utility_Functions.store_input_array(Utility_Functions.get_processed_array)
            lblBinarySearchInput.Text = Utility_Functions.array_to_string(Utility_Functions.get_input_array)
        End If
    End Sub
End Class
