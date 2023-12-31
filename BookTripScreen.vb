﻿Public Class BookTripScreen

    'Book Trip Screen'

    Private Sub BackBox_Click(sender As Object, e As EventArgs) Handles BackBox.Click
        Me.Hide()
        Form1.RiderMainScreen1.Show()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FromLocationBox.Items.Add("Your current location.")
        FromLocationBox.Items.Add("Yonge Dundas Square")
        FromLocationBox.Items.Add("TMU")

        ToLocationBox.Items.Add("123 Queen Street")
        ToLocationBox.Items.Add("123 Yonge Street")
        ToLocationBox.Items.Add("123 King Street")

        PeopleComboBox.Items.Add(1)
        PeopleComboBox.Items.Add(2)
        PeopleComboBox.Items.Add(3)
        PeopleComboBox.Items.Add(4)

        StartTimeBox.Items.Add("11:00AM")
        StartTimeBox.Items.Add("12:00PM")
        StartTimeBox.Items.Add("1:00PM")
        StartTimeBox.Items.Add("2:00PM")
        StartTimeBox.Items.Add("3:00PM")
        StartTimeBox.Items.Add("4:00PM")

        EndTimeBox.Items.Add("11:00AM")
        EndTimeBox.Items.Add("12:00PM")
        EndTimeBox.Items.Add("1:00PM")
        EndTimeBox.Items.Add("2:00PM")
        EndTimeBox.Items.Add("3:00PM")
        EndTimeBox.Items.Add("4:00PM")
        EndTimeBox.Items.Add("5:00PM")

        FromTimeLabel.Hide()
        EndTimeLabel.Hide()
        StartTimeBox.Hide()
        EndTimeBox.Hide()

    End Sub

    Private Sub NowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NowRadioButton.CheckedChanged
        FromTimeLabel.Hide()
        EndTimeLabel.Show()
        StartTimeBox.Hide()
        EndTimeBox.Show()
    End Sub

    Private Sub LaterRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LaterRadioButton.CheckedChanged
        FromTimeLabel.Show()
        EndTimeLabel.Show()
        StartTimeBox.Show()
        EndTimeBox.Show()
    End Sub

    Private Sub BookButton_Click(sender As Object, e As EventArgs) Handles BookButton.Click
        Form1.riderBooking.FromLocation = FromLocationBox.Text
        Form1.riderBooking.ToLocation = ToLocationBox.Text
        Form1.riderBooking.NumberOfPeople = Integer.Parse(PeopleComboBox.Text)
        Form1.CarBooked = True

        If NowRadioButton.Checked = True Then
            Form1.riderBooking.FromTime = "10:00AM"
            Form1.riderBooking.ToTime = EndTimeBox.Text
            Form1.riderBooking.BookingStatus = True
            Form1.CarBooked = True
            Form1.RiderMainScreen1.bookCheck()

        End If

        If LaterRadioButton.Checked = True Then
            Form1.riderBooking.FromTime = StartTimeBox.Text
            Form1.riderBooking.ToTime = EndTimeBox.Text
            Form1.riderBooking.BookingStatus = True
            Form1.CarBooked = True
            Form1.RiderMainScreen1.bookCheck()
        End If

        Form1.CurrentTripControl1.Book()
        Me.Hide()
        Form1.CurrentTripControl1.BringToFront()
        Form1.CurrentTripControl1.Show()
        Form1.Requestdetails1.tripdetails.Text = "Name: " + Form1.riderBooking.RiderName + vbCrLf + "From: " + Form1.riderBooking.FromLocation + vbCrLf + "To: " + Form1.riderBooking.ToLocation + vbCrLf + "Number of people: " + Form1.riderBooking.NumberOfPeople.ToString() + vbCrLf + "Start time: " + Form1.riderBooking.FromTime + vbCrLf + "End time: " + Form1.riderBooking.ToTime
        Form1.CurrentTripControl1.Timer.Start()


        Form1.CurrentTripControl1.TitleLabel.Left = (Form1.CurrentTripControl1.TitleLabel.Parent.Width \ 2) - (Form1.CurrentTripControl1.TitleLabel.Width \ 2) - 3
        Form1.CurrentTripControl1.startLabel.Left = (Form1.CurrentTripControl1.startLabel.Parent.Width \ 2) - (Form1.CurrentTripControl1.startLabel.Width \ 2) - 3
        Form1.CurrentTripControl1.StartDestinationLabel.Left = (Form1.CurrentTripControl1.StartDestinationLabel.Parent.Width \ 2) - (Form1.CurrentTripControl1.StartDestinationLabel.Width \ 2) - 3
        Form1.CurrentTripControl1.endLabel.Left = (Form1.CurrentTripControl1.endLabel.Parent.Width \ 2) - (Form1.CurrentTripControl1.endLabel.Width \ 2) - 3
        Form1.CurrentTripControl1.DestinationLabel.Left = (Form1.CurrentTripControl1.DestinationLabel.Parent.Width \ 2) - (Form1.CurrentTripControl1.DestinationLabel.Width \ 2) - 3
        Form1.CurrentTripControl1.ArrivedLabel.Left = (Form1.CurrentTripControl1.ArrivedLabel.Parent.Width \ 2) - (Form1.CurrentTripControl1.ArrivedLabel.Width \ 2) - 3
    End Sub

End Class
