Imports System.Net.Http
Imports System.Xml.Schema
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports DotNetEnv

Public Class SkyCast
    Env.Load()
    Private Const OpenWeatherMapApiKey As String = Env.GetString("API_KEY") ' Replace with your OpenWeatherMap API key
    Public _iconCode
    Public _currentTemperature As String
    Public _currentCondition As String
    Public _precipitation As Double
    Public _humidity As Integer
    Public iconUrl As String
    Public _forecastedTemperatures As List(Of String)
    Public _hourlyForecastIcons As List(Of String) ' Added to store hourly forecast weather icons

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                Dim userLocation = TextBox1.Text
                FetchAndStoreWeatherInfo(userLocation)
                Label1.Text = _currentTemperature
                If _currentCondition = "" Then
                    MsgBox("Place Doesn't Exist")
                Else
                    Label2.Text = "Condition: " + _currentCondition.ToString()
                    _currentCondition = ""
                    Label3.Text = "Precipitation: " + _precipitation.ToString()
                    Label4.Text = "Humidity: " + _humidity.ToString()
                    Label6.Text = userLocation
                    iconUrl = "http://openweathermap.org/img/wn/" + _iconCode + "@4x.png"
                    PictureBox1.ImageLocation = iconUrl
                        DisplayForecastedTemperatures()
                    DisplayHourlyForecastIcons()
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim userLocation = TextBox1.Text
            FetchAndStoreWeatherInfo(userLocation)
            Label1.Text = _currentTemperature
            If _currentCondition = "" Then
                MsgBox("Place Doesn't Exist")
            Else
                Label2.Text = "Condition: " + _currentCondition.ToString()
                _currentCondition = ""
                Label3.Text = "Precipitation: " + _precipitation.ToString()
                Label4.Text = "Humidity: " + _humidity.ToString()
                Label6.Text = userLocation
                iconUrl = "http://openweathermap.org/img/wn/" + _iconCode + "@4x.png"
                PictureBox1.ImageLocation = iconUrl
                DisplayForecastedTemperatures()
                DisplayHourlyForecastIcons()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' To Be Tested
    Private Sub DisplayForecastedTemperatures()
        If _forecastedTemperatures IsNot Nothing Then
            TextBoxForecast1.Text = _forecastedTemperatures(0)
            TextBoxForecast2.Text = _forecastedTemperatures(1)
            TextBoxForecast3.Text = _forecastedTemperatures(2)
        End If
    End Sub

    ' Added to display hourly forecast weather icons
    Private Sub DisplayHourlyForecastIcons()
        If _hourlyForecastIcons IsNot Nothing Then
            ' Assuming you have PictureBoxes named PictureBox1Hour1, PictureBox2Hour2, PictureBox3Hour3, etc.
            For i As Integer = 1 To Math.Min(_hourlyForecastIcons.Count - 1, 6) ' Display up to 4 icons
                Dim pictureBoxName As String = $"PictureBox{i + 1}"
                Dim pictureBox As PictureBox = Controls.Find(pictureBoxName, True).FirstOrDefault()
                If pictureBox IsNot Nothing Then
                    pictureBox.ImageLocation = _hourlyForecastIcons(i)
                End If
            Next
        End If
    End Sub

    Private Function FetchAndStoreWeatherInfo(location As String)
        Try
            Dim apiKey As String = OpenWeatherMapApiKey
            Dim currentWeatherApiUrl As String = $"http://api.openweathermap.org/data/2.5/weather?q={location}&appid={apiKey}&units=metric"
            Dim forecastApiUrl As String = $"http://api.openweathermap.org/data/2.5/forecast?q={location}&appid={apiKey}&units=metric"
            'weather
            Using httpClient As New HttpClient()
                Dim response As HttpResponseMessage = httpClient.GetAsync(currentWeatherApiUrl).Result

                If response.IsSuccessStatusCode Then
                    Dim jsonContent As String = response.Content.ReadAsStringAsync().Result
                    Console.WriteLine("Current Weather API Response: " & jsonContent) ' Log API response to console

                    Dim weatherData As WeatherData = JsonConvert.DeserializeObject(Of WeatherData)(jsonContent)

                    If weatherData IsNot Nothing AndAlso weatherData.Weather.Count > 0 Then
                        _currentTemperature = $"{weatherData.Main.Temp}°C"
                        _currentCondition = weatherData.Weather(0).Description
                        _precipitation = If(weatherData.Rain?.PrecipitationVolume, 0)
                        _humidity = If(weatherData.Main?.Humidity, 0)
                        _iconCode = weatherData.Weather(0).Icon
                    Else
                        Dim errorResponse As ErrorResponse = JsonConvert.DeserializeObject(Of ErrorResponse)(jsonContent)
                        Throw New Exception($"Error fetching current weather: {errorResponse.Message}")
                        ' Handle error conditions here...
                        _currentTemperature = ""
                        _currentCondition = ""
                        _precipitation = 0
                        _humidity = 0
                    End If
                Else
                    Console.WriteLine($"HTTP Error: {response.StatusCode}")
                End If
            End Using
            'forecast
            Using httpClient As New HttpClient()
                Dim response As HttpResponseMessage = httpClient.GetAsync(forecastApiUrl).Result

                If response.IsSuccessStatusCode Then
                    Dim jsonContent As String = response.Content.ReadAsStringAsync().Result
                    Console.WriteLine("Forecast API Response: " & jsonContent) ' Log API response to console

                    Dim forecastData As ForecastData = JsonConvert.DeserializeObject(Of ForecastData)(jsonContent)

                    If forecastData IsNot Nothing Then
                        _forecastedTemperatures = forecastData.List.Take(4).Select(Function(item) $"{item.Main.Temp}°C").ToList()
                        _hourlyForecastIcons = forecastData.List.Take(4).Select(Function(item) $"http://openweathermap.org/img/wn/{item.Weather(0).Icon}@4x.png").ToList()
                    Else
                        TextBoxForecast1.Text = 0
                        TextBoxForecast2.Text = 0
                        TextBoxForecast3.Text = 0
                    End If
                Else
                    Console.WriteLine($"HTTP Error: {response.StatusCode}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching weather information: {ex.Message}")
        End Try
    End Function
    Public Class ErrorResponse
        Public Property Message As String
    End Class
    Public Class ForecastData
        Public Property List As List(Of ForecastItem)
    End Class

    Public Class ForecastItem
        Public Property Main As MainData
        Public Property Weather As List(Of WeatherDescription)
    End Class

    Public Class WeatherData
        Public Property Main As MainData
        Public Property Weather As List(Of WeatherDescription)
        Public Property Rain As RainData ' Assuming Rain is a direct property of WeatherData
    End Class

    Public Class MainData
        Public Property Temp As Double
        Public Property Humidity As Integer ' Assuming Humidity is a direct property of MainData
    End Class

    Public Class WeatherDescription
        Public Property Icon As String
        Public Property Description As String
    End Class

    Public Class RainData
        Public Property PrecipitationVolume As Double
    End Class

End Class
