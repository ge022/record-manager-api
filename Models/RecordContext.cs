using Microsoft.EntityFrameworkCore;

namespace Tutorial.Models {

    public class RecordContext: DbContext {
        
        public RecordContext(DbContextOptions<recordContext> options): base(options) { }
        
        public virtual DbSet<Record> Records { get; set; }
        
    }
}