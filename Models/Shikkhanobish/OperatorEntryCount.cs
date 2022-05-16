using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHikkhanobishAPI.Models.Shikkhanobish
{
    public class OperatorEntryCount
    {
        public int operatorID { get; set; }
        public int UploadCount { get; set; }
        public int ApprovedCount { get; set; }
        public int DeclineCount { get; set; }
        public int PendingCount { get; set; }
        public int Type { get; set; }
        public string Response { get; set; }

        //create procedure setOperatorEntryCount
        //@operatorID int,
        //@UploadCount int,
        //@ApprovedCount int,
        //@DeclineCount int,
        //@PendingCount int,
        //@Type int
        //as begin
        //insert into OperatorEntryCount(operatorID, UploadCount , ApprovedCount  , DeclineCount   , PendingCount, Type)
        //values(@operatorID, @UploadCount    , @ApprovedCount, @DeclineCount   , @PendingCount, @Type)
        //end


  //      alter procedure setOperatorEntryCountWithID
  //@operatorID int,
  //      @UploadCount int,
  //      @ApprovedCount int,
  //      @DeclineCount int,
  //      @PendingCount int,
  //      @Type int
  //      as begin
  //      Update OperatorEntryCount
  //      set UploadCount = @UploadCount, ApprovedCount = @ApprovedCount , DeclineCount = @DeclineCount , PendingCount = @PendingCount
  //       where operatorID = @operatorID and Type = @Type
  //      end


        //create procedure getOperatorEntryCountWithID
        //@operatorID int
        //as begin
        //select* from  OperatorEntryCount where operatorID = @operatorID
        //end
    }
}