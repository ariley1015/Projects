<html>

<head>
<title>Register User</title>
<script LANGUAGE="VBScript">

Sub SendRequest_OnClick()
Window.location.href = "srvmsgsend.asp?Label=User Register Request&Body=" & UserName.Value & "|" & Password.Value  & "|" & EMailId.Value  & "|" & Address.Value  & "|" & Sex.Value  & "|" & BirthDay.Value  & "|" & Age.Value 
End Sub

</script>

</head>

<body>

<p align="left">Register User</p>

<table border="1" width="526" height="46">
  <tr>
    <td width="186" height="15">Enter Your Details</td>
    <td width="328" height="15"><img src="user.jpg" width="123" height="148" alt="user.jpg (4412 bytes)"></td>
  </tr>
  <tr>
    <td width="186" height="15">User Name:</td>
    <td width="328" height="15"><INPUT TYPE=Text VALUE="" NAME="UserName" size="35"></td>
  </tr>
  <tr>
    <td width="186" height="19">Password:</td>
    <td width="328" height="19"><INPUT TYPE="password" VALUE="" NAME="Password"></td>
  </tr>
  <tr>
    <td width="186" height="19">Age:</td>
    <td width="328" height="19"><INPUT TYPE=Text VALUE="" NAME="Age" size="3"></td>
  </tr>
  <tr>
    <td width="186" height="19">Sex:</td>
    <td width="328" height="19">
    				<select size="1" name="Sex">
    				<option selected value="Female">Female</option>
    				<option value="Male">Male</option>
  				</select>
    </td>
  </tr>
  <tr>
    <td width="186" height="19">Address:</td>
    <td width="328" height="19"><TEXTAREA style="WIDTH: 28em; Font: 8pt Tahoma, MS Shell Dlg" border=0 cols=55 rows=4 Name = "Address"></TEXTAREA></td>
  </tr>
  <tr>
    <td width="186" height="19">Email Id:</td>
    <td width="328" height="19"><INPUT TYPE=Text VALUE="" NAME="EMailId"></td>
  </tr>
  <tr>
    <td width="186" height="19">BirthDay:</td>
    <td width="328" height="19"><INPUT TYPE=Text VALUE="" NAME="BirthDay"></td>
  </tr>
</table>

<INPUT TYPE=Button VALUE="Send Request" NAME="SendRequest">

<p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>

<p>&nbsp;</p>
</body>
</html>
