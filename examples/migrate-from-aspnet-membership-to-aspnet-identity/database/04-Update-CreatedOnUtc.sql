UPDATE TOP(1) AspNetUsers 
   SET AspNetUsers.CreatedOnUtc = aspnet_Membership.CreateDate 
   FROM AspNetUsers INNER JOIN aspnet_Membership 
   ON AspNetUsers.Id = aspnet_Membership.UserId
   WHERE AspNetUsers.CreatedOnUtc IS NULL