<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	    
	<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
	<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script> 
    <meta name="viewport" content="width=device-width, initial-scale=1">
	<title>Dashboard</title>

	<link rel="stylesheet" href="../static/dashboard.css">
	<link rel="icon" href="../static/document.png" type="Image/icon">	
	
	<script src="https://kit.fontawesome.com/a81368914c.js"></script>

	<!--boothstrap links-->
	
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>

</head>

<body>

    <CENTER>
<br />
<h1>
	Document Management System
</h1>
	    Login as : 
	<asp:Label ID="Label2" runat="server"></asp:Label>
		

	<div class="container">
		<div class="stepno">

			<div class="row">

				<div class="col-lg-12">

					<form id="form2" runat="server">
							
						
           				<br>
						<p> 							
							Find Documents by entering Client Id or Document Number						    
						</p>

						<br />

						<asp:TextBox ID="TextBox3" runat="server" Height="37px" Width="234px"></asp:TextBox>

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                        <asp:Button ID="Button3" runat="server" class="btn btn-primary" Text="Show" OnClick="Button2_Click" Height="40px" Width="100px" />
                        
						<br />

							<asp:Label ID="Label1" runat="server" style="color: red; font-size: 30px"></asp:Label>
						<br>
                        
            	<h2>Client Details</h2>

					<div class="container">
 
            
						<table class="table table-hover">
							<thead>
								<tr>
									<th>First Name</th>
									<th>Last Name</th>
									<th>Email</th>
								</tr>
							</thead>
						<tbody>
						  <tr>
							<td>
								<asp:TextBox ID="firstName" runat="server"></asp:TextBox>
							</td>
							<td>
								<asp:TextBox ID="lastName" runat="server"></asp:TextBox>
							</td>
							<td>
								<asp:TextBox ID="Email" runat="server"></asp:TextBox>

							</td>
						  </tr>
      
						</tbody>
					  </table>
					</div>
											   			
						
						<div class="container">
  							
                            <h3>Client Documents</h3>
  							
  							<table class="table table-striped" align="CENTER">
    							<thead>
      								<tr>
        								<th>Document Name</th>
        								<th>Document</th>
										<th>Description</th>
										          							
      								</tr>
    							</thead>

    							<tbody>
      								<tr>
        								<td> <br><br><br><br> Photo</td>
								        
								        <td>
											<asp:Image ID="Image1" runat="server" class="img-rounded" data-toggle="modal" data-target="#myModal" alt="Cinque Terre" Height="200" />
											<div class="modal fade" id="myModal">
												<div class="modal-dialog modal-lg">
													<center>
														<asp:Image ID="Image1_1" runat="server" class="img-rounded" alt="Cinque Terre" Height="500" />
														<br /> <br />
														<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
													</center>
												</div>
											</div>
											<br />
											<br />
											<asp:FileUpload ID="photoUpdate" runat="server"></asp:FileUpload>
											&nbsp;&nbsp;&nbsp;
											<asp:Button ID="picUpdate" runat="server" class="btn btn-info" Text="Update" OnClick="picUpdate_Click"></asp:Button>
										</td>

										
					      			</tr>
					      			<tr>
								        <td> <br><br> Signature</td>
								        <td> <asp:Image ID="Image2" runat="server" class="img-rounded" data-toggle="modal" data-target="#myModal2" alt="Cinque Terre" Height="100" />
											 <div class="modal fade" id="myModal2">
												<div class="modal-dialog modal-lg">
													<center>
														<br /> <br />
														<asp:Image ID="Image2_2" runat="server" class="img-rounded" alt="Cinque Terre" Height="300" />
														<br /> <br />
														<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
													</center>
												</div>
											</div>
											<br />
											<br />
                                            <asp:FileUpload ID="signUpdate" runat="server" />
											&nbsp;&nbsp;&nbsp;
											<asp:Button ID="signPicUpdate" runat="server" class="btn btn-info" Text="Update" OnClick="signPicUpdate_Click"></asp:Button>
											
								        </td>								        
					      			</tr>
					      			<tr>
							        	<td> <br><br><br><br> Proof of Identity</td>
							        	<td> <asp:Image ID="Image3" runat="server" class="img-rounded" data-toggle="modal" data-target="#myModal3" alt="Cinque Terre" Height="100" />
											 <div class="modal fade" id="myModal3">
												<div class="modal-dialog modal-lg">
													<center>
														<asp:Image ID="Image3_3" runat="server" class="img-rounded" alt="Cinque Terre" Height="500" />
														<br /> <br />
														<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
													</center>
												</div>
											</div>
											<br />
											<br />
                                            <asp:FileUpload ID="identityUpdate" runat="server" />
											&nbsp;&nbsp;&nbsp;
											<asp:Button ID="idPicUpdate" runat="server" class="btn btn-info" Text="Update" OnClick="idPicUpdate_Click"></asp:Button>
								        </td>
							        	<td>
											Document Number<br />
											&nbsp;<asp:TextBox ID="IdentityNum" runat="server"></asp:TextBox>
							        	</td>
							      	</tr>
							      	<tr>
							        	<td> <br><br><br><br> Proof of Income</td>
							        	<td> <asp:Image ID="Image4" runat="server" class="img-rounded" data-toggle="modal" data-target="#myModal4" alt="Cinque Terre" Height="100" />
											 <div class="modal fade" id="myModal4">
												<div class="modal-dialog modal-lg">
													<center>
														<asp:Image ID="Image4_4" runat="server" class="img-rounded" alt="Cinque Terre" Height="500" />
														<br /> <br />
														<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
													</center>
												</div>
											</div>
											<br />
											<br />
                                            <asp:FileUpload ID="incomeUpdate" runat="server" />
											&nbsp;&nbsp;&nbsp;
											<asp:Button ID="incomePicUpdate" runat="server" class="btn btn-info" Text="Update" OnClick="incomePicUpdate_Click"></asp:Button>
								        </td>
							        	<td>
											Document Number<br />
											&nbsp;<asp:TextBox ID="IncomeNum" runat="server"></asp:TextBox>
							        	</td>
							      	</tr>
							      	<tr>
							        	<td> <br><br><br><br> Proof of Address</td>
							        	<td> <asp:Image ID="Image5" runat="server" class="img-rounded" data-toggle="modal" data-target="#myModal5" alt="Cinque Terre" Height="100" />
											 <div class="modal fade" id="myModal5">
												<div class="modal-dialog modal-lg">
													<center>
														<asp:Image ID="Image5_5" runat="server" class="img-rounded" alt="Cinque Terre" Height="500" />
														<br /> <br />
														<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
													</center>
												</div>
											</div>
											<br />
											<br />
                                            <asp:FileUpload ID="addressUpdate" runat="server" />
											&nbsp;&nbsp;&nbsp;
											<asp:Button ID="addressPicUpdate" runat="server" class="btn btn-info" Text="Update" OnClick="addressPicUpdate_Click"></asp:Button>
								        </td>
							        	<td>
											Address<br />
											&nbsp;<asp:TextBox ID="addressNum" runat="server"></asp:TextBox>
							        	</td>
							      	</tr>
							      	<tr>
							        	<td> <br><br><br><br> Details of Related Person</td>
							        	<td> <asp:Image ID="Image6" runat="server" class="img-rounded" data-toggle="modal" data-target="#myModal6" alt="Cinque Terre" Height="100" />
											 <div class="modal fade" id="myModal6">
												<div class="modal-dialog modal-lg">
													<center>
														<asp:Image ID="Image6_6" runat="server" class="img-rounded" alt="Cinque Terre" Height="500" />
														<br /> <br />
														<button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
													</center>
												</div>
											</div>
											<br />
											<br />
                                            <asp:FileUpload ID="relationUpdate" runat="server" />
											&nbsp;&nbsp;&nbsp;
											<asp:Button ID="relationPicUpdate" runat="server" class="btn btn-info" Text="Update" OnClick="relationPicUpdate_Click"></asp:Button>
								        </td>
										<td>
											Document Number<br />
											&nbsp;<asp:TextBox ID="relationNum" runat="server"></asp:TextBox>
							        	</td>
							      	</tr>
					    		</tbody>
					  		</table>
						</div>
						
						<br />
						
						<asp:Button ID="Button5" runat="server" Text="Update" class="btn btn-primary" OnClick="Button5_Click"></asp:Button>

							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

						<asp:Button ID="Button6" runat="server" Text="Remove" class="btn btn-danger" OnClick="Button6_Click"></asp:Button>

						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

						<asp:Button ID="Button7" runat="server" Text="Clear" class="btn btn-primary" OnClick="Button7_Click"></asp:Button>
						
					    <br />
                        <br />
					</form>	
				</div>
                				
			</div>

			
		</div>
	</div>

<br>
	
    </CENTER>

  
</body>
</html>
