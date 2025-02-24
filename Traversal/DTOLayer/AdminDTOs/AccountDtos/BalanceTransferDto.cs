namespace Traversal.DTOLayer.AdminDTOs.AccountDtos
{
    public class BalanceTransferDto
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
    }
}
