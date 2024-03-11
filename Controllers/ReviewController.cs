// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using BookingApp.Models;

// namespace BookingApp.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class ReviewController : ControllerBase
//     {
//         private readonly BookingContext _context;

//         public ReviewController(BookingContext context)
//         {
//             _context = context;
//         }

//         // GET: api/Review
//         [HttpGet]
//         public async Task<ActionResult<IEnumerable<Review>>> GetReviews()
//         {
//             return await _context.Reviews.ToListAsync();
//         }

//         // GET: api/Review/5
//         [HttpGet("{id}")]
//         public async Task<ActionResult<Review>> GetReview(int id)
//         {
//             var review = await _context.Reviews.FindAsync(id);

//             if (review == null)
//             {
//                 return NotFound();
//             }

//             return review;
//         }

//         // POST: api/Review
//         [HttpPost]
//         public async Task<ActionResult<Review>> PostReview(Review review)
//         {
//             _context.Reviews.Add(review);
//             await _context.SaveChangesAsync();

//             return CreatedAtAction(nameof(GetReview), new { id = review.Id }, review);
//         }

//         // PUT: api/Review/5
//         [HttpPut("{id}")]
//         public async Task<IActionResult> PutReview(int id, Review review)
//         {
//             if (id != review.Id)
//             {
//                 return BadRequest();
//             }

//             _context.Entry(review).State = EntityState.Modified;

//             try
//             {
//                 await _context.SaveChangesAsync();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!ReviewExists(id))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }

//             return NoContent();
//         }

//         // DELETE: api/Review/5
//         [HttpDelete("{id}")]
//         public async Task<IActionResult> DeleteReview(int id)
//         {
//             var review = await _context.Reviews.FindAsync(id);
//             if (review == null)
//             {
//                 return NotFound();
//             }

//             _context.Reviews.Remove(review);
//             await _context.SaveChangesAsync();

//             return NoContent();
//         }

//         private bool ReviewExists(int id)
//         {
//             return _context.Reviews.Any(e => e.Id == id);
//         }
//     }
// }
