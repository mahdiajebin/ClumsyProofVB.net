

Insert Into PRODUCT(Id, Name, Price, Description, Image, Type)



Select '40', N'RIFLE PAPER CO.', N'20.99', N'Keep it fresh with genuine flowers!  Delicately dried flowers with eye-catching metallic elements are encased in clear resin to give this case a truly elegant twist. ', BulkColumn , N'Tablet'

from Openrowset (Bulk 'C:\Users\mahdi\source\repos\ClumsyProofV7\ClumsyProofV7\Resources\t14.jpg', Single_Blob) as Image
