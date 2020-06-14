using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlogApp.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("タイトル")]
        public string Title { get; set; }

        [Required]
        [DisplayName("本文")]
        public string Body { get; set; }

        //実際の日時はコントローラーで設定するのでRequiredは不要
        [DisplayName("投稿日")]
        public DateTime Created { get; set; }

        [DisplayName("更新日")]
        public DateTime Modified { get; set; }
        
        //commentコレクションのナビゲーションプロパティ
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        //画面での入力保持だけに用いるため、テーブルに登録しない
        [NotMapped]
        [DisplayName("カテゴリー")]
        public string CategoryName { get; set; }

    }
}