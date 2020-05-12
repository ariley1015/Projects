<html>

<head>
<title>Request User Details</title>
<script LANGUAGE="VBScript">

Sub SendRequest_OnClick()
Window.location.href = "srvmsgsend.asp?Label=User Detail Request&Body=" & EMailId.Value
End Sub


</script>

</head>

<body>

<p align="left">Request User Details</p>

<table border="1" width="526" height="46">
  <tr>
    <td width="186" height="15">Request User Details</td>
    <td width="328" height="15"><img src="user.jpg" width="123" height="148" alt="user.jpg (4412 bytes)"></td>
  </tr>
  <tr>
    <td width="186" height="15">Enter Your Email Id:</td>
    <td width="328" height="15"><INPUT TYPE=Text VALUE="" NAME="EMailId" size = 35></td>
  </tr>
</table>

<INPUT TYPE=Button VALUE="Send Request" NAME="SendRequest">

<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>

<p>&nbsp;</p>
</body>
</html>
