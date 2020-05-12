<%@ LANGUAGE="VBSCRIPT" %>

<html>

<head>
<title>Message Server Script</title>

<%	
      on Error resume next
      set queueinfo = CreateObject ("MSMQ.MSMQQueueInfo")
      queueinfo.PathName = ".\InboundRequests"
      queueinfo.Create
      set queue = queueinfo.Open ( 2, 0 )
      If queue.IsOpen Then
            Set message = CreateObject("MSMQ.MSMQMessage")
            message.Body = CStr (Request.QueryString ( "Body" ))
            message.Label = CStr (Request.QueryString ( "Label" ))
            message.Send queue
            Response.Write "Message has been sent, you will be notified ASAP."
      End If
      queue.Close
%>

</script>

</head>

<body>
<A HREF="Default.asp"><home></A>
</body>
</html>
