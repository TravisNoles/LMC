Public Class frmMain


    'Looks up the distances between cities

    Private Sub cmdLookup_Click(sender As Object, e As EventArgs) Handles cmdLookup.Click


        'Declare array to store names
        'Dim citiesName(,) As String = {{"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"},
        '                       {"Boston", "Chicago", "Dallas", "Las Vegas", "Los Angeles", "Miami", "New Orleans", "Toronto", "Vancouver", "Washington DC"}}


        'Store table of differences between miles (pg. 358) 
        Dim citiesDist(,) As Integer = {{0, 1004, 1753, 2752, 3017, 1520, 1507, 609, 3155, 448},
                                        {1004, 0, 921, 1790, 2048, 1397, 919, 515, 2176, 709},
                                        {1753, 921, 0, 1230, 1399, 1343, 517, 1435, 2234, 1307},
                                        {2752, 1780, 1230, 0, 272, 2570, 1732, 2251, 1322, 2420},
                                        {3017, 2048, 1399, 272, 0, 2716, 1858, 2523, 1278, 2646},
                                        {1520, 1397, 1343, 2570, 2716, 0, 860, 1494, 3447, 1057},
                                        {1507, 919, 517, 1732, 1858, 860, 0, 1307, 2734, 1099},
                                        {609, 515, 1435, 2251, 2523, 1494, 1307, 0, 2820, 571},
                                        {3155, 2176, 2234, 1322, 1278, 3447, 2734, 2820, 0, 2887},
                                        {448, 709, 1307, 2420, 2646, 1057, 1099, 571, 2887, 0}}

        lblDistanceCalc.Text = citiesDist(cbCity1.SelectedIndex, cbCity2.SelectedIndex)

    End Sub

End Class
